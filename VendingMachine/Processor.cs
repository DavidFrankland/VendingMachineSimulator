using System;
using System.Collections.Generic;
using System.Globalization;

namespace VendingMachine
{
    public class Processor
    {
        private string displayText;
        private readonly IFormatProvider formatProvider = new CultureInfo("en-US");
        private const string InsertCoinText = "INSERT COIN";

        public decimal MoneyInCoinReturn { get; private set; }

        public decimal MoneyInMachine { get; private set; }

        private readonly Dictionary<int, decimal> validCoins = new Dictionary<int, decimal>
        {
            { 5, 0.05m },
            { 10, 0.10m },
            { 20, 0.20m },
            { 50, 0.50m },
            { 100, 1.00m },
            { 200, 2.00m },
        };

        public enum ProductTypes
        {
            Cola,
            Chips,
            Candy
        }

        private readonly Dictionary<ProductTypes, decimal> availableProducts = new Dictionary<ProductTypes, decimal>
        {
            { ProductTypes.Cola, 1.00m },
            { ProductTypes.Chips, 0.50m },
            { ProductTypes.Candy, 0.65m },
        };

        public void SelectProduct(ProductTypes productType)
        {
            var productPrice = availableProducts[productType];

            if (MoneyInMachine >= productPrice)
            {
                // dispense product
                displayText = "THANK YOU";
                MoneyInCoinReturn = MoneyInMachine - productPrice;
                MoneyInMachine = 0;
            }
            else
            {
                displayText = "PRICE " + FormatPrice(productPrice);
            }
        }

        private string FormatPrice(decimal value)
        {
            return string.Format(formatProvider, "{0:c}", value);
        }

        public decimal IdentifyCoin(int coinSize)
        {
            if (validCoins.ContainsKey(coinSize))
            {
                return validCoins[coinSize];
            }

            return 0;
        }

        public void InsertCoin(int size)
        {
            var coinValue = IdentifyCoin(size);

            if (coinValue > 0)
            {
                MoneyInMachine += coinValue;
            }
            else
            {
                // coin is not valid, return it to the user
            }
        }

        public void ReturnCoins()
        {
            MoneyInCoinReturn += MoneyInMachine;
            MoneyInMachine = 0;
        }

        public void CollectMoneyInCoinReturn()
        {
            MoneyInCoinReturn = 0;
        }

        public Display GetDisplay()
        {
            var display = new Display();

            if (displayText != null)
            {
                display.Text = displayText;
                display.MoreMessages = true;
                displayText = null;
            }
            else
            {
                if (MoneyInMachine > 0)
                {
                    display.Text = FormatPrice(MoneyInMachine);
                    display.MoreMessages = false;
                }
                else
                {
                    display.Text = InsertCoinText;
                    display.MoreMessages = false;
                }
            }

            return display;
        }
    }
}
