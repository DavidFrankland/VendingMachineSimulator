using System;
using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;

namespace VendingMachine.Tests
{
    [TestFixture]
    public class ProcessorTests
    {
        private Processor processor;
        private const string InsertCoinText = "INSERT COIN";
        private const string ThankYouText = "THANK YOU";

        [SetUp]
        public void SetUp()
        {
            processor = new Processor();
        }

        [Test]
        public void GetDisplayText_displays_INSERT_COIN_at_start()
        {
            // arrange

            // act
            var display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(InsertCoinText);
            display.MoreMessages.Should().BeFalse();
        }

        [TestCase(5, 0.05)]
        [TestCase(10, 0.10)]
        [TestCase(20, 0.20)]
        [TestCase(50, 0.50)]
        [TestCase(100, 1.00)]
        [TestCase(200, 2.00)]
        public void IdentifyCoin_identifies_valid_coins(int coinSize, decimal expectedValue)
        {
            // arrange

            // act
            var value = processor.IdentifyCoin(coinSize);

            // assert
            value.Should().Be(expectedValue);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(37)]
        public void IdentifyCoin_rejects_invalid_coins(int coinSize)
        {
            // arrange

            // act
            var value = processor.IdentifyCoin(coinSize);

            // assert
            value.Should().Be(0);
        }

        [TestCase(5, "$0.05")]
        [TestCase(10, "$0.10")]
        [TestCase(20, "$0.20")]
        [TestCase(50, "$0.50")]
        [TestCase(100, "$1.00")]
        [TestCase(200, "$2.00")]
        public void GetDisplay_displays_value_of_single_coin_inserted(int coinSize, string expectedDisplayText)
        {
            // arrange
            processor.InsertCoin(coinSize);

            // act
            var display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(expectedDisplayText);
            display.MoreMessages.Should().BeFalse();
        }

        [Test]
        public void GetDisplay_displays_value_of_all_money_inserted()
        {
            // arrange
            processor.InsertCoin(5);
            processor.InsertCoin(10);
            processor.InsertCoin(20);
            const string expectedDisplayText = "$0.35";

            // act
            var display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(expectedDisplayText);
            display.MoreMessages.Should().BeFalse();
        }

        [TestCase(Processor.ProductTypes.Cola, "PRICE $1.00")]
        [TestCase(Processor.ProductTypes.Chips, "PRICE $0.50")]
        [TestCase(Processor.ProductTypes.Candy, "PRICE $0.65")]
        public void GetDisplay_displays_selected_product_price_when_not_enough_money(Processor.ProductTypes productType, string expectedDisplayText)
        {
            // arrange
            processor.SelectProduct(productType);

            // act
            var display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(expectedDisplayText);
            display.MoreMessages.Should().BeTrue();
        }

        [TestCase(Processor.ProductTypes.Cola)]
        [TestCase(Processor.ProductTypes.Chips)]
        [TestCase(Processor.ProductTypes.Candy)]
        public void GetDisplay_displays_current_amount_after_displaying_product_price(Processor.ProductTypes productType)
        {
            // arrange
            processor.InsertCoin(10);
            const string expectedDisplayText = "$0.10";
            processor.SelectProduct(productType);
            var display = processor.GetDisplay();

            // act
            display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(expectedDisplayText);
            display.MoreMessages.Should().BeFalse();
        }

        [TestCase(Processor.ProductTypes.Cola, 100)]
        [TestCase(Processor.ProductTypes.Chips, 50)]
        [TestCase(Processor.ProductTypes.Candy, 50, 10, 5)]
        public void GetDisplay_displays_THANK_YOU_when_product_dispensed(Processor.ProductTypes productType, params int[] coins)
        {
            // arrange
            foreach (var coin in coins)
            {
                processor.InsertCoin(coin);
            }
            processor.SelectProduct(productType);

            // act
            var display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(ThankYouText);
            display.MoreMessages.Should().BeTrue();
        }

        [TestCase(Processor.ProductTypes.Cola, 100)]
        [TestCase(Processor.ProductTypes.Chips, 50)]
        [TestCase(Processor.ProductTypes.Candy, 50, 10, 5)]
        public void GetDisplay_displays_INSERT_COIN_after_product_dispensed(Processor.ProductTypes productType, params int[] coins)
        {
            // arrange
            foreach (var coin in coins)
            {
                processor.InsertCoin(coin);
            }
            processor.SelectProduct(productType);
            var display = processor.GetDisplay();

            // act
            display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(InsertCoinText);
            display.MoreMessages.Should().BeFalse();
        }

        [Test]
        public void GetDisplay_displays_INSERT_COIN_after_money_returned()
        {
            // arrange
            processor.InsertCoin(5);
            processor.InsertCoin(10);
            processor.InsertCoin(20);
            processor.ReturnCoins();

            // act
            var display = processor.GetDisplay();

            // assert
            display.Text.Should().Be(InsertCoinText);
            display.MoreMessages.Should().BeFalse();
        }

        [Test]
        public void MoneyInMachine_accumulates_value_of_single_coin_inserted()
        {
            // arrange
            processor.InsertCoin(5);
            processor.InsertCoin(10);
            processor.InsertCoin(20);
            const decimal expectedMoneyInMachine = 0.35m;

            // act
            var moneyInMachine = processor.MoneyInMachine;

            // assert
            moneyInMachine.Should().Be(expectedMoneyInMachine);
        }

        [TestCase(Processor.ProductTypes.Cola, 100)]
        [TestCase(Processor.ProductTypes.Chips, 50)]
        [TestCase(Processor.ProductTypes.Candy, 50, 10, 5)]
        public void MoneyInMachine_is_zero_after_product_dispensed_when_paying_exact_amount(Processor.ProductTypes productType, params int[] coins)
        {
            // arrange
            foreach (var coin in coins)
            {
                processor.InsertCoin(coin);
            }
            processor.SelectProduct(productType);

            // act
            var moneyInMachine = processor.MoneyInMachine;

            // assert
            moneyInMachine.Should().Be(0);
        }

        [TestCase(Processor.ProductTypes.Cola, 100, 50)]
        [TestCase(Processor.ProductTypes.Chips, 20, 20, 20)]
        [TestCase(Processor.ProductTypes.Candy, 50, 10, 20)]
        public void MoneyInMachine_is_zero_after_product_dispensed_when_paying_too_much(Processor.ProductTypes productType, params int[] coins)
        {
            // arrange
            foreach (var coin in coins)
            {
                processor.InsertCoin(coin);
            }
            processor.SelectProduct(productType);

            // act
            var moneyInMachine = processor.MoneyInMachine;

            // assert
            moneyInMachine.Should().Be(0);
        }

        [TestCase(Processor.ProductTypes.Cola, 100)]
        [TestCase(Processor.ProductTypes.Chips, 50)]
        [TestCase(Processor.ProductTypes.Candy, 50, 10, 5)]
        public void MoneyInCoinReturn_is_zero_after_product_dispensed_when_paying_exact_amount(Processor.ProductTypes productType, params int[] coins)
        {
            // arrange
            foreach (var coin in coins)
            {
                processor.InsertCoin(coin);
            }
            processor.SelectProduct(productType);

            // act
            var moneyInCoinReturn = processor.MoneyInCoinReturn;

            // assert
            moneyInCoinReturn.Should().Be(0);
        }

        [TestCase(0.50, Processor.ProductTypes.Cola, 100, 50)]
        [TestCase(0.10, Processor.ProductTypes.Chips, 20, 20, 20)]
        [TestCase(0.15, Processor.ProductTypes.Candy, 50, 10, 20)]
        public void MoneyInCoinReturn_is_zero_after_product_dispensed_when_paying_too_much(decimal expectedMoneyInCoinReturn, Processor.ProductTypes productType, params int[] coins)
        {
            // arrange
            foreach (var coin in coins)
            {
                processor.InsertCoin(coin);
            }
            processor.SelectProduct(productType);

            // act
            var moneyInCoinReturn = processor.MoneyInCoinReturn;

            // assert
            moneyInCoinReturn.Should().Be(expectedMoneyInCoinReturn);
        }

        [TestCase(1.50, 100, 50)]
        [TestCase(0.60, 20, 20, 20)]
        [TestCase(0.80, 50, 10, 20)]
        public void ReturnCoins_returns_all_money_to_coin_return(decimal expectedMoneyInCoinReturn, params int[] coins)
        {
            // arrange
            foreach (var coin in coins)
            {
                processor.InsertCoin(coin);
            }
            processor.ReturnCoins();

            // act
            var moneyInCoinReturn = processor.MoneyInCoinReturn;

            // assert
            moneyInCoinReturn.Should().Be(expectedMoneyInCoinReturn);
        }

        [Test]
        public void MoneyInMachine_is_zero_after_money_returned()
        {
            // arrange
            processor.InsertCoin(5);
            processor.InsertCoin(10);
            processor.InsertCoin(20);
            processor.ReturnCoins();

            // act
            var moneyInMachine = processor.MoneyInMachine;

            // assert
            moneyInMachine.Should().Be(0);
        }

        [Test]
        public void MoneyInCoinReturn_is_zero_after_money_collected()
        {
            // arrange
            processor.InsertCoin(5);
            processor.InsertCoin(10);
            processor.InsertCoin(20);
            processor.ReturnCoins();
            processor.CollectMoneyInCoinReturn();

            // act
            var moneyInCoinReturn = processor.MoneyInCoinReturn;

            // assert
            moneyInCoinReturn.Should().Be(0);
        }

        [Test]
        public void MoneyInCoinReturn_accumulates_after_money_returned_but_not_collected()
        {
            // arrange
            processor.InsertCoin(5);
            processor.ReturnCoins();
            processor.InsertCoin(10);
            processor.ReturnCoins();
            processor.InsertCoin(20);
            processor.ReturnCoins();
            const decimal expectedMoneyInCoinReturn = 0.35m;

            // act
            var moneyInCoinReturn = processor.MoneyInCoinReturn;

            // assert
            moneyInCoinReturn.Should().Be(expectedMoneyInCoinReturn);
        }
    }
}
