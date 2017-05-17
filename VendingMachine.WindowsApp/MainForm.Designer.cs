namespace VendingMachine.WindowsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.displayTextLabel = new System.Windows.Forms.Label();
            this.coinsGroupBox = new System.Windows.Forms.GroupBox();
            this.returnCoinsButton = new System.Windows.Forms.Button();
            this.collectCoinsButton = new System.Windows.Forms.Button();
            this.insert5cButton = new System.Windows.Forms.Button();
            this.insert10cButton = new System.Windows.Forms.Button();
            this.insert20cButton = new System.Windows.Forms.Button();
            this.insertCustomButton = new System.Windows.Forms.Button();
            this.insert50cButton = new System.Windows.Forms.Button();
            this.insert100cButton = new System.Windows.Forms.Button();
            this.insert200cButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customCoinTextBox = new System.Windows.Forms.TextBox();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.selectColaButton = new System.Windows.Forms.Button();
            this.selectChipsButton = new System.Windows.Forms.Button();
            this.selectCandyButton = new System.Windows.Forms.Button();
            this.moneyInMachineGroupBox = new System.Windows.Forms.GroupBox();
            this.coinReturnGroupBox = new System.Windows.Forms.GroupBox();
            this.moneyInMachineLabel = new System.Windows.Forms.Label();
            this.moneyInCoinReturnLabel = new System.Windows.Forms.Label();
            this.coinsGroupBox.SuspendLayout();
            this.productsGroupBox.SuspendLayout();
            this.moneyInMachineGroupBox.SuspendLayout();
            this.coinReturnGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTimer
            // 
            this.displayTimer.Interval = 2000;
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // displayTextLabel
            // 
            this.displayTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.displayTextLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextLabel.ForeColor = System.Drawing.Color.White;
            this.displayTextLabel.Location = new System.Drawing.Point(12, 9);
            this.displayTextLabel.Name = "displayTextLabel";
            this.displayTextLabel.Size = new System.Drawing.Size(406, 36);
            this.displayTextLabel.TabIndex = 0;
            this.displayTextLabel.Text = "Display Text";
            this.displayTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coinsGroupBox
            // 
            this.coinsGroupBox.Controls.Add(this.customCoinTextBox);
            this.coinsGroupBox.Controls.Add(this.insert5cButton);
            this.coinsGroupBox.Controls.Add(this.label3);
            this.coinsGroupBox.Controls.Add(this.insert10cButton);
            this.coinsGroupBox.Controls.Add(this.insert200cButton);
            this.coinsGroupBox.Controls.Add(this.insert20cButton);
            this.coinsGroupBox.Controls.Add(this.insert100cButton);
            this.coinsGroupBox.Controls.Add(this.insertCustomButton);
            this.coinsGroupBox.Controls.Add(this.insert50cButton);
            this.coinsGroupBox.Location = new System.Drawing.Point(12, 58);
            this.coinsGroupBox.Name = "coinsGroupBox";
            this.coinsGroupBox.Size = new System.Drawing.Size(406, 82);
            this.coinsGroupBox.TabIndex = 4;
            this.coinsGroupBox.TabStop = false;
            this.coinsGroupBox.Text = "Insert coin";
            // 
            // returnCoinsButton
            // 
            this.returnCoinsButton.Location = new System.Drawing.Point(11, 42);
            this.returnCoinsButton.Name = "returnCoinsButton";
            this.returnCoinsButton.Size = new System.Drawing.Size(75, 23);
            this.returnCoinsButton.TabIndex = 0;
            this.returnCoinsButton.Text = "Return coins";
            this.returnCoinsButton.UseVisualStyleBackColor = true;
            this.returnCoinsButton.Click += new System.EventHandler(this.returnCoinsButton_Click);
            // 
            // collectCoinsButton
            // 
            this.collectCoinsButton.Location = new System.Drawing.Point(11, 42);
            this.collectCoinsButton.Name = "collectCoinsButton";
            this.collectCoinsButton.Size = new System.Drawing.Size(75, 23);
            this.collectCoinsButton.TabIndex = 5;
            this.collectCoinsButton.Text = "Collect coins";
            this.collectCoinsButton.UseVisualStyleBackColor = true;
            this.collectCoinsButton.Click += new System.EventHandler(this.collectCoinsButton_Click);
            // 
            // insert5cButton
            // 
            this.insert5cButton.Location = new System.Drawing.Point(6, 19);
            this.insert5cButton.Name = "insert5cButton";
            this.insert5cButton.Size = new System.Drawing.Size(50, 23);
            this.insert5cButton.TabIndex = 6;
            this.insert5cButton.Text = "5c";
            this.insert5cButton.UseVisualStyleBackColor = true;
            this.insert5cButton.Click += new System.EventHandler(this.insert5cButton_Click);
            // 
            // insert10cButton
            // 
            this.insert10cButton.Location = new System.Drawing.Point(62, 19);
            this.insert10cButton.Name = "insert10cButton";
            this.insert10cButton.Size = new System.Drawing.Size(50, 23);
            this.insert10cButton.TabIndex = 7;
            this.insert10cButton.Text = "10c";
            this.insert10cButton.UseVisualStyleBackColor = true;
            this.insert10cButton.Click += new System.EventHandler(this.insert10cButton_Click);
            // 
            // insert20cButton
            // 
            this.insert20cButton.Location = new System.Drawing.Point(118, 19);
            this.insert20cButton.Name = "insert20cButton";
            this.insert20cButton.Size = new System.Drawing.Size(50, 23);
            this.insert20cButton.TabIndex = 8;
            this.insert20cButton.Text = "20c";
            this.insert20cButton.UseVisualStyleBackColor = true;
            this.insert20cButton.Click += new System.EventHandler(this.insert20cButton_Click);
            // 
            // insertCustomButton
            // 
            this.insertCustomButton.Location = new System.Drawing.Point(286, 48);
            this.insertCustomButton.Name = "insertCustomButton";
            this.insertCustomButton.Size = new System.Drawing.Size(50, 23);
            this.insertCustomButton.TabIndex = 9;
            this.insertCustomButton.Text = "Insert";
            this.insertCustomButton.UseVisualStyleBackColor = true;
            this.insertCustomButton.Click += new System.EventHandler(this.insertCustomButton_Click);
            // 
            // insert50cButton
            // 
            this.insert50cButton.Location = new System.Drawing.Point(174, 19);
            this.insert50cButton.Name = "insert50cButton";
            this.insert50cButton.Size = new System.Drawing.Size(50, 23);
            this.insert50cButton.TabIndex = 10;
            this.insert50cButton.Text = "50c";
            this.insert50cButton.UseVisualStyleBackColor = true;
            this.insert50cButton.Click += new System.EventHandler(this.insert50cButton_Click);
            // 
            // insert100cButton
            // 
            this.insert100cButton.Location = new System.Drawing.Point(230, 19);
            this.insert100cButton.Name = "insert100cButton";
            this.insert100cButton.Size = new System.Drawing.Size(50, 23);
            this.insert100cButton.TabIndex = 11;
            this.insert100cButton.Text = "$1";
            this.insert100cButton.UseVisualStyleBackColor = true;
            this.insert100cButton.Click += new System.EventHandler(this.insert100cButton_Click);
            // 
            // insert200cButton
            // 
            this.insert200cButton.Location = new System.Drawing.Point(286, 19);
            this.insert200cButton.Name = "insert200cButton";
            this.insert200cButton.Size = new System.Drawing.Size(50, 23);
            this.insert200cButton.TabIndex = 12;
            this.insert200cButton.Text = "$2";
            this.insert200cButton.UseVisualStyleBackColor = true;
            this.insert200cButton.Click += new System.EventHandler(this.insert200cButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Custom coin size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // customCoinTextBox
            // 
            this.customCoinTextBox.Location = new System.Drawing.Point(230, 50);
            this.customCoinTextBox.Name = "customCoinTextBox";
            this.customCoinTextBox.Size = new System.Drawing.Size(50, 20);
            this.customCoinTextBox.TabIndex = 14;
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.selectCandyButton);
            this.productsGroupBox.Controls.Add(this.selectChipsButton);
            this.productsGroupBox.Controls.Add(this.selectColaButton);
            this.productsGroupBox.Location = new System.Drawing.Point(12, 146);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(406, 57);
            this.productsGroupBox.TabIndex = 15;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Select product";
            // 
            // selectColaButton
            // 
            this.selectColaButton.Location = new System.Drawing.Point(6, 19);
            this.selectColaButton.Name = "selectColaButton";
            this.selectColaButton.Size = new System.Drawing.Size(75, 23);
            this.selectColaButton.TabIndex = 0;
            this.selectColaButton.Text = "Cola";
            this.selectColaButton.UseVisualStyleBackColor = true;
            this.selectColaButton.Click += new System.EventHandler(this.selectColaButton_Click);
            // 
            // selectChipsButton
            // 
            this.selectChipsButton.Location = new System.Drawing.Point(87, 19);
            this.selectChipsButton.Name = "selectChipsButton";
            this.selectChipsButton.Size = new System.Drawing.Size(75, 23);
            this.selectChipsButton.TabIndex = 1;
            this.selectChipsButton.Text = "Chips";
            this.selectChipsButton.UseVisualStyleBackColor = true;
            this.selectChipsButton.Click += new System.EventHandler(this.selectChipsButton_Click);
            // 
            // selectCandyButton
            // 
            this.selectCandyButton.Location = new System.Drawing.Point(168, 19);
            this.selectCandyButton.Name = "selectCandyButton";
            this.selectCandyButton.Size = new System.Drawing.Size(75, 23);
            this.selectCandyButton.TabIndex = 2;
            this.selectCandyButton.Text = "Candy";
            this.selectCandyButton.UseVisualStyleBackColor = true;
            this.selectCandyButton.Click += new System.EventHandler(this.selectCandyButton_Click);
            // 
            // moneyInMachineGroupBox
            // 
            this.moneyInMachineGroupBox.Controls.Add(this.moneyInMachineLabel);
            this.moneyInMachineGroupBox.Controls.Add(this.returnCoinsButton);
            this.moneyInMachineGroupBox.Location = new System.Drawing.Point(12, 209);
            this.moneyInMachineGroupBox.Name = "moneyInMachineGroupBox";
            this.moneyInMachineGroupBox.Size = new System.Drawing.Size(200, 78);
            this.moneyInMachineGroupBox.TabIndex = 16;
            this.moneyInMachineGroupBox.TabStop = false;
            this.moneyInMachineGroupBox.Text = "Money in the machine";
            // 
            // coinReturnGroupBox
            // 
            this.coinReturnGroupBox.Controls.Add(this.moneyInCoinReturnLabel);
            this.coinReturnGroupBox.Controls.Add(this.collectCoinsButton);
            this.coinReturnGroupBox.Location = new System.Drawing.Point(218, 209);
            this.coinReturnGroupBox.Name = "coinReturnGroupBox";
            this.coinReturnGroupBox.Size = new System.Drawing.Size(200, 78);
            this.coinReturnGroupBox.TabIndex = 17;
            this.coinReturnGroupBox.TabStop = false;
            this.coinReturnGroupBox.Text = "Money in the coin return";
            // 
            // moneyInMachineLabel
            // 
            this.moneyInMachineLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyInMachineLabel.Location = new System.Drawing.Point(6, 16);
            this.moneyInMachineLabel.Name = "moneyInMachineLabel";
            this.moneyInMachineLabel.Size = new System.Drawing.Size(188, 23);
            this.moneyInMachineLabel.TabIndex = 1;
            this.moneyInMachineLabel.Text = "$0.00";
            // 
            // moneyInCoinReturnLabel
            // 
            this.moneyInCoinReturnLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyInCoinReturnLabel.Location = new System.Drawing.Point(6, 16);
            this.moneyInCoinReturnLabel.Name = "moneyInCoinReturnLabel";
            this.moneyInCoinReturnLabel.Size = new System.Drawing.Size(188, 23);
            this.moneyInCoinReturnLabel.TabIndex = 6;
            this.moneyInCoinReturnLabel.Text = "$0.00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 300);
            this.Controls.Add(this.coinReturnGroupBox);
            this.Controls.Add(this.moneyInMachineGroupBox);
            this.Controls.Add(this.productsGroupBox);
            this.Controls.Add(this.coinsGroupBox);
            this.Controls.Add(this.displayTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.coinsGroupBox.ResumeLayout(false);
            this.coinsGroupBox.PerformLayout();
            this.productsGroupBox.ResumeLayout(false);
            this.moneyInMachineGroupBox.ResumeLayout(false);
            this.coinReturnGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.Label displayTextLabel;
        private System.Windows.Forms.GroupBox coinsGroupBox;
        private System.Windows.Forms.TextBox customCoinTextBox;
        private System.Windows.Forms.Button insert5cButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insert10cButton;
        private System.Windows.Forms.Button insert200cButton;
        private System.Windows.Forms.Button insert20cButton;
        private System.Windows.Forms.Button insert100cButton;
        private System.Windows.Forms.Button insertCustomButton;
        private System.Windows.Forms.Button insert50cButton;
        private System.Windows.Forms.Button returnCoinsButton;
        private System.Windows.Forms.Button collectCoinsButton;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.Button selectCandyButton;
        private System.Windows.Forms.Button selectChipsButton;
        private System.Windows.Forms.Button selectColaButton;
        private System.Windows.Forms.GroupBox moneyInMachineGroupBox;
        private System.Windows.Forms.Label moneyInMachineLabel;
        private System.Windows.Forms.GroupBox coinReturnGroupBox;
        private System.Windows.Forms.Label moneyInCoinReturnLabel;
    }
}

