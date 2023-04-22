namespace StockMarket
{
    partial class FormLive
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
            this.userControlLiveData1 = new StockMarket.Components.UserControlLiveData();
            this.SuspendLayout();
            // 
            // userControlLiveData1
            // 
            this.userControlLiveData1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlLiveData1.BasePrice = null;
            this.userControlLiveData1.BuyPrice = null;
            this.userControlLiveData1.DaysToApply = null;
            this.userControlLiveData1.Location = new System.Drawing.Point(45, 58);
            this.userControlLiveData1.Name = "userControlLiveData1";
            this.userControlLiveData1.ProfitInPercent = null;
            this.userControlLiveData1.SellPrice = null;
            this.userControlLiveData1.Size = new System.Drawing.Size(724, 76);
            this.userControlLiveData1.StrikePrice = null;
            this.userControlLiveData1.SymbolBaseName = null;
            this.userControlLiveData1.SymbolName = null;
            this.userControlLiveData1.TabIndex = 0;
            this.userControlLiveData1.Url = null;
            this.userControlLiveData1.UrlBase = null;
            // 
            // FormLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.userControlLiveData1);
            this.Name = "FormLive";
            this.Text = "FormRatio";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.UserControlLiveData userControlLiveData1;
    }
}