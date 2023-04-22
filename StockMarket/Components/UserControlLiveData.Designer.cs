
namespace StockMarket.Components
{
    partial class UserControlLiveData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelSellPrice = new System.Windows.Forms.Label();
            this.labelBuyPrice = new System.Windows.Forms.Label();
            this.labelBasePrice = new System.Windows.Forms.Label();
            this.labelDaysToApply = new System.Windows.Forms.Label();
            this.labelProfitInPercent = new System.Windows.Forms.Label();
            this.labelStrikePrice = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Location = new System.Drawing.Point(16, 14);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(69, 13);
            this.labelSymbol.TabIndex = 0;
            this.labelSymbol.Text = "SymbolName";
            // 
            // labelSellPrice
            // 
            this.labelSellPrice.AutoSize = true;
            this.labelSellPrice.Location = new System.Drawing.Point(95, 14);
            this.labelSellPrice.Name = "labelSellPrice";
            this.labelSellPrice.Size = new System.Drawing.Size(48, 13);
            this.labelSellPrice.TabIndex = 1;
            this.labelSellPrice.Text = "SellPrice";
            // 
            // labelBuyPrice
            // 
            this.labelBuyPrice.AutoSize = true;
            this.labelBuyPrice.Location = new System.Drawing.Point(186, 14);
            this.labelBuyPrice.Name = "labelBuyPrice";
            this.labelBuyPrice.Size = new System.Drawing.Size(49, 13);
            this.labelBuyPrice.TabIndex = 2;
            this.labelBuyPrice.Text = "BuyPrice";
            // 
            // labelBasePrice
            // 
            this.labelBasePrice.AutoSize = true;
            this.labelBasePrice.Location = new System.Drawing.Point(354, 14);
            this.labelBasePrice.Name = "labelBasePrice";
            this.labelBasePrice.Size = new System.Drawing.Size(55, 13);
            this.labelBasePrice.TabIndex = 3;
            this.labelBasePrice.Text = "BasePrice";
            // 
            // labelDaysToApply
            // 
            this.labelDaysToApply.AutoSize = true;
            this.labelDaysToApply.Location = new System.Drawing.Point(415, 14);
            this.labelDaysToApply.Name = "labelDaysToApply";
            this.labelDaysToApply.Size = new System.Drawing.Size(70, 13);
            this.labelDaysToApply.TabIndex = 4;
            this.labelDaysToApply.Text = "DaysToApply";
            // 
            // labelProfitInPercent
            // 
            this.labelProfitInPercent.AutoSize = true;
            this.labelProfitInPercent.Location = new System.Drawing.Point(504, 14);
            this.labelProfitInPercent.Name = "labelProfitInPercent";
            this.labelProfitInPercent.Size = new System.Drawing.Size(77, 13);
            this.labelProfitInPercent.TabIndex = 5;
            this.labelProfitInPercent.Text = "ProfitInPercent";
            // 
            // labelStrikePrice
            // 
            this.labelStrikePrice.AutoSize = true;
            this.labelStrikePrice.Location = new System.Drawing.Point(267, 14);
            this.labelStrikePrice.Name = "labelStrikePrice";
            this.labelStrikePrice.Size = new System.Drawing.Size(58, 13);
            this.labelStrikePrice.TabIndex = 6;
            this.labelStrikePrice.Text = "StrikePrice";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(614, 9);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Start";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(19, 46);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Message";
            // 
            // UserControlLiveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.labelStrikePrice);
            this.Controls.Add(this.labelProfitInPercent);
            this.Controls.Add(this.labelDaysToApply);
            this.Controls.Add(this.labelBasePrice);
            this.Controls.Add(this.labelBuyPrice);
            this.Controls.Add(this.labelSellPrice);
            this.Controls.Add(this.labelSymbol);
            this.Name = "UserControlLiveData";
            this.Size = new System.Drawing.Size(724, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelSellPrice;
        private System.Windows.Forms.Label labelBuyPrice;
        private System.Windows.Forms.Label labelBasePrice;
        private System.Windows.Forms.Label labelDaysToApply;
        private System.Windows.Forms.Label labelProfitInPercent;
        private System.Windows.Forms.Label labelStrikePrice;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelMessage;
    }
}
