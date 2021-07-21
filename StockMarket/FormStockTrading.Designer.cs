namespace StockMarket
{
    partial class FormStockTrading
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
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStockInfo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.radioButtonSell = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPricePerShare = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(132, 32);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stcok";
            // 
            // comboBoxStockInfo
            // 
            this.comboBoxStockInfo.FormattingEnabled = true;
            this.comboBoxStockInfo.Location = new System.Drawing.Point(132, 74);
            this.comboBoxStockInfo.Name = "comboBoxStockInfo";
            this.comboBoxStockInfo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStockInfo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trade Type";
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Checked = true;
            this.radioButtonBuy.Location = new System.Drawing.Point(132, 116);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBuy.TabIndex = 5;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Buy";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            // 
            // radioButtonSell
            // 
            this.radioButtonSell.AutoSize = true;
            this.radioButtonSell.Location = new System.Drawing.Point(211, 113);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSell.TabIndex = 6;
            this.radioButtonSell.Text = "Sell";
            this.radioButtonSell.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Volume";
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(132, 154);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(121, 20);
            this.textBoxVolume.TabIndex = 8;
            this.textBoxVolume.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price Per Share";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Price";
            // 
            // textBoxPricePerShare
            // 
            this.textBoxPricePerShare.Location = new System.Drawing.Point(132, 195);
            this.textBoxPricePerShare.Name = "textBoxPricePerShare";
            this.textBoxPricePerShare.Size = new System.Drawing.Size(121, 20);
            this.textBoxPricePerShare.TabIndex = 11;
            this.textBoxPricePerShare.Text = "0";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(132, 236);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalPrice.TabIndex = 12;
            this.textBoxTotalPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(31, 301);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(341, 43);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(31, 373);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 16;
            this.labelMessage.Text = "Message";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // FormStockTrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textBoxPricePerShare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonSell);
            this.Controls.Add(this.radioButtonBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStockInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxName);
            this.Name = "FormStockTrading";
            this.Text = "FormStockTrading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStockInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.RadioButton radioButtonSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPricePerShare;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}