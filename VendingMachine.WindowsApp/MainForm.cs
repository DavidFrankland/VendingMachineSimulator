using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace VendingMachine.WindowsApp
{
    public partial class MainForm : Form
    {
        private readonly Processor processor = new Processor();
        private readonly IFormatProvider formatProvider = new CultureInfo("en-US");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            moneyInMachineLabel.Text = processor.MoneyInMachine.ToString("C", formatProvider);
            moneyInCoinReturnLabel.Text = processor.MoneyInCoinReturn.ToString("C", formatProvider);

            var display = processor.GetDisplay();
            displayTextLabel.Text = display.Text;

            // if there are more messages, display them after a couple of seconds delay
            if (display.MoreMessages)
            {
                displayTimer.Stop();
                displayTimer.Interval = 2000;
                displayTimer.Start();
            }
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            var display = processor.GetDisplay();
            displayTextLabel.Text = display.Text;

            // if there are no more messages, stop the timer
            if (!display.MoreMessages)
            {
                displayTimer.Stop();
            }
        }

        private void insert5cButton_Click(object sender, EventArgs e)
        {
            processor.InsertCoin(5);
            UpdateDisplays();
        }

        private void insert10cButton_Click(object sender, EventArgs e)
        {
            processor.InsertCoin(10);
            UpdateDisplays();
        }

        private void insert20cButton_Click(object sender, EventArgs e)
        {
            processor.InsertCoin(20);
            UpdateDisplays();
        }

        private void insert50cButton_Click(object sender, EventArgs e)
        {
            processor.InsertCoin(50);
            UpdateDisplays();
        }

        private void insert100cButton_Click(object sender, EventArgs e)
        {
            processor.InsertCoin(100);
            UpdateDisplays();
        }

        private void insert200cButton_Click(object sender, EventArgs e)
        {
            processor.InsertCoin(200);
            UpdateDisplays();
        }

        private void insertCustomButton_Click(object sender, EventArgs e)
        {
            int coinSize;

            if (int.TryParse(customCoinTextBox.Text, out coinSize))
            {
                processor.InsertCoin(coinSize);
                UpdateDisplays();
            }
        }

        private void selectColaButton_Click(object sender, EventArgs e)
        {
            processor.SelectProduct(Processor.ProductTypes.Cola);
            UpdateDisplays();
        }

        private void selectChipsButton_Click(object sender, EventArgs e)
        {
            processor.SelectProduct(Processor.ProductTypes.Chips);
            UpdateDisplays();
        }

        private void selectCandyButton_Click(object sender, EventArgs e)
        {
            processor.SelectProduct(Processor.ProductTypes.Candy);
            UpdateDisplays();
        }

        private void returnCoinsButton_Click(object sender, EventArgs e)
        {
            processor.ReturnCoins();
            UpdateDisplays();
        }

        private void collectCoinsButton_Click(object sender, EventArgs e)
        {
            processor.CollectMoneyInCoinReturn();
            UpdateDisplays();
        }
    }
}
