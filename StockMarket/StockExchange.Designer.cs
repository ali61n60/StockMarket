namespace StockMarket
{
    partial class StockExchange
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalPriceSold = new System.Windows.Forms.TextBox();
            this.textBoxPricePerShareSold = new System.Windows.Forms.TextBox();
            this.labelTotalPrice1 = new System.Windows.Forms.Label();
            this.labelPricePerShare1 = new System.Windows.Forms.Label();
            this.textBoxVolumeSold = new System.Windows.Forms.TextBox();
            this.labelVolume1 = new System.Windows.Forms.Label();
            this.labelSold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.panelSold = new System.Windows.Forms.Panel();
            this.symbolSelector1 = new StockMarket.Components.SymbolSelector();
            this.panelBought = new System.Windows.Forms.Panel();
            this.symbolSelector2 = new StockMarket.Components.SymbolSelector();
            this.labelVolume2 = new System.Windows.Forms.Label();
            this.textBoxVolumeBought = new System.Windows.Forms.TextBox();
            this.labelPricePerShare2 = new System.Windows.Forms.Label();
            this.labelTotalPrice2 = new System.Windows.Forms.Label();
            this.textBoxPricePerShareBought = new System.Windows.Forms.TextBox();
            this.labelBought = new System.Windows.Forms.Label();
            this.textBoxTotalPriceBought = new System.Windows.Forms.TextBox();
            this.panelSold.SuspendLayout();
            this.panelBought.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(183, 428);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 33;
            this.labelMessage.Text = "Message";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(186, 362);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(341, 43);
            this.buttonSubmit.TabIndex = 32;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Date";
            // 
            // textBoxTotalPriceSold
            // 
            this.textBoxTotalPriceSold.Location = new System.Drawing.Point(126, 171);
            this.textBoxTotalPriceSold.Name = "textBoxTotalPriceSold";
            this.textBoxTotalPriceSold.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalPriceSold.TabIndex = 30;
            this.textBoxTotalPriceSold.Text = "0";
            // 
            // textBoxPricePerShareSold
            // 
            this.textBoxPricePerShareSold.Location = new System.Drawing.Point(126, 130);
            this.textBoxPricePerShareSold.Name = "textBoxPricePerShareSold";
            this.textBoxPricePerShareSold.Size = new System.Drawing.Size(121, 20);
            this.textBoxPricePerShareSold.TabIndex = 29;
            this.textBoxPricePerShareSold.Text = "0";
            // 
            // labelTotalPrice1
            // 
            this.labelTotalPrice1.AutoSize = true;
            this.labelTotalPrice1.Location = new System.Drawing.Point(25, 175);
            this.labelTotalPrice1.Name = "labelTotalPrice1";
            this.labelTotalPrice1.Size = new System.Drawing.Size(58, 13);
            this.labelTotalPrice1.TabIndex = 28;
            this.labelTotalPrice1.Text = "Total Price";
            // 
            // labelPricePerShare1
            // 
            this.labelPricePerShare1.AutoSize = true;
            this.labelPricePerShare1.Location = new System.Drawing.Point(25, 134);
            this.labelPricePerShare1.Name = "labelPricePerShare1";
            this.labelPricePerShare1.Size = new System.Drawing.Size(81, 13);
            this.labelPricePerShare1.TabIndex = 27;
            this.labelPricePerShare1.Text = "Price Per Share";
            // 
            // textBoxVolumeSold
            // 
            this.textBoxVolumeSold.Location = new System.Drawing.Point(126, 89);
            this.textBoxVolumeSold.Name = "textBoxVolumeSold";
            this.textBoxVolumeSold.Size = new System.Drawing.Size(121, 20);
            this.textBoxVolumeSold.TabIndex = 26;
            this.textBoxVolumeSold.Text = "0";
            // 
            // labelVolume1
            // 
            this.labelVolume1.AutoSize = true;
            this.labelVolume1.Location = new System.Drawing.Point(25, 93);
            this.labelVolume1.Name = "labelVolume1";
            this.labelVolume1.Size = new System.Drawing.Size(42, 13);
            this.labelVolume1.TabIndex = 25;
            this.labelVolume1.Text = "Volume";
            // 
            // labelSold
            // 
            this.labelSold.AutoSize = true;
            this.labelSold.Location = new System.Drawing.Point(4, 10);
            this.labelSold.Name = "labelSold";
            this.labelSold.Size = new System.Drawing.Size(28, 13);
            this.labelSold.TabIndex = 22;
            this.labelSold.Text = "Sold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(138, 21);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 18;
            // 
            // panelSold
            // 
            this.panelSold.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSold.Controls.Add(this.symbolSelector1);
            this.panelSold.Controls.Add(this.labelVolume1);
            this.panelSold.Controls.Add(this.textBoxVolumeSold);
            this.panelSold.Controls.Add(this.labelPricePerShare1);
            this.panelSold.Controls.Add(this.labelTotalPrice1);
            this.panelSold.Controls.Add(this.textBoxPricePerShareSold);
            this.panelSold.Controls.Add(this.labelSold);
            this.panelSold.Controls.Add(this.textBoxTotalPriceSold);
            this.panelSold.Location = new System.Drawing.Point(40, 119);
            this.panelSold.Name = "panelSold";
            this.panelSold.Size = new System.Drawing.Size(306, 217);
            this.panelSold.TabIndex = 35;
            // 
            // symbolSelector1
            // 
            this.symbolSelector1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.symbolSelector1.Location = new System.Drawing.Point(63, 3);
            this.symbolSelector1.Name = "symbolSelector1";
            this.symbolSelector1.Size = new System.Drawing.Size(198, 77);
            this.symbolSelector1.TabIndex = 31;
            // 
            // panelBought
            // 
            this.panelBought.Controls.Add(this.symbolSelector2);
            this.panelBought.Controls.Add(this.labelVolume2);
            this.panelBought.Controls.Add(this.textBoxVolumeBought);
            this.panelBought.Controls.Add(this.labelPricePerShare2);
            this.panelBought.Controls.Add(this.labelTotalPrice2);
            this.panelBought.Controls.Add(this.textBoxPricePerShareBought);
            this.panelBought.Controls.Add(this.labelBought);
            this.panelBought.Controls.Add(this.textBoxTotalPriceBought);
            this.panelBought.Location = new System.Drawing.Point(426, 119);
            this.panelBought.Name = "panelBought";
            this.panelBought.Size = new System.Drawing.Size(306, 217);
            this.panelBought.TabIndex = 36;
            // 
            // symbolSelector2
            // 
            this.symbolSelector2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.symbolSelector2.Location = new System.Drawing.Point(73, 10);
            this.symbolSelector2.Name = "symbolSelector2";
            this.symbolSelector2.Size = new System.Drawing.Size(198, 77);
            this.symbolSelector2.TabIndex = 31;
            // 
            // labelVolume2
            // 
            this.labelVolume2.AutoSize = true;
            this.labelVolume2.Location = new System.Drawing.Point(25, 93);
            this.labelVolume2.Name = "labelVolume2";
            this.labelVolume2.Size = new System.Drawing.Size(42, 13);
            this.labelVolume2.TabIndex = 25;
            this.labelVolume2.Text = "Volume";
            // 
            // textBoxVolumeBought
            // 
            this.textBoxVolumeBought.Location = new System.Drawing.Point(126, 89);
            this.textBoxVolumeBought.Name = "textBoxVolumeBought";
            this.textBoxVolumeBought.Size = new System.Drawing.Size(121, 20);
            this.textBoxVolumeBought.TabIndex = 26;
            this.textBoxVolumeBought.Text = "0";
            // 
            // labelPricePerShare2
            // 
            this.labelPricePerShare2.AutoSize = true;
            this.labelPricePerShare2.Location = new System.Drawing.Point(25, 134);
            this.labelPricePerShare2.Name = "labelPricePerShare2";
            this.labelPricePerShare2.Size = new System.Drawing.Size(81, 13);
            this.labelPricePerShare2.TabIndex = 27;
            this.labelPricePerShare2.Text = "Price Per Share";
            // 
            // labelTotalPrice2
            // 
            this.labelTotalPrice2.AutoSize = true;
            this.labelTotalPrice2.Location = new System.Drawing.Point(25, 175);
            this.labelTotalPrice2.Name = "labelTotalPrice2";
            this.labelTotalPrice2.Size = new System.Drawing.Size(58, 13);
            this.labelTotalPrice2.TabIndex = 28;
            this.labelTotalPrice2.Text = "Total Price";
            // 
            // textBoxPricePerShareBought
            // 
            this.textBoxPricePerShareBought.Location = new System.Drawing.Point(126, 130);
            this.textBoxPricePerShareBought.Name = "textBoxPricePerShareBought";
            this.textBoxPricePerShareBought.Size = new System.Drawing.Size(121, 20);
            this.textBoxPricePerShareBought.TabIndex = 29;
            this.textBoxPricePerShareBought.Text = "0";
            // 
            // labelBought
            // 
            this.labelBought.AutoSize = true;
            this.labelBought.Location = new System.Drawing.Point(4, 10);
            this.labelBought.Name = "labelBought";
            this.labelBought.Size = new System.Drawing.Size(41, 13);
            this.labelBought.TabIndex = 22;
            this.labelBought.Text = "Bought";
            // 
            // textBoxTotalPriceBought
            // 
            this.textBoxTotalPriceBought.Location = new System.Drawing.Point(126, 171);
            this.textBoxTotalPriceBought.Name = "textBoxTotalPriceBought";
            this.textBoxTotalPriceBought.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalPriceBought.TabIndex = 30;
            this.textBoxTotalPriceBought.Text = "0";
            // 
            // StockExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.panelBought);
            this.Controls.Add(this.panelSold);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxName);
            this.Name = "StockExchange";
            this.Text = "StockExchange";
            this.panelSold.ResumeLayout(false);
            this.panelSold.PerformLayout();
            this.panelBought.ResumeLayout(false);
            this.panelBought.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalPriceSold;
        private System.Windows.Forms.TextBox textBoxPricePerShareSold;
        private System.Windows.Forms.Label labelTotalPrice1;
        private System.Windows.Forms.Label labelPricePerShare1;
        private System.Windows.Forms.TextBox textBoxVolumeSold;
        private System.Windows.Forms.Label labelVolume1;
        private System.Windows.Forms.Label labelSold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Panel panelSold;
        private System.Windows.Forms.Panel panelBought;
        private System.Windows.Forms.Label labelVolume2;
        private System.Windows.Forms.TextBox textBoxVolumeBought;
        private System.Windows.Forms.Label labelPricePerShare2;
        private System.Windows.Forms.Label labelTotalPrice2;
        private System.Windows.Forms.TextBox textBoxPricePerShareBought;
        private System.Windows.Forms.Label labelBought;
        private System.Windows.Forms.TextBox textBoxTotalPriceBought;
        private Components.SymbolSelector symbolSelector1;
        private Components.SymbolSelector symbolSelector2;
    }
}