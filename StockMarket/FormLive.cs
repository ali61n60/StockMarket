using ModelStd.Option;
using RepositoryStd.FileSystem.Option;
using ServiceStd.LiveData;
using StockMarket.Components;
using System.Windows.Forms;
using System;


namespace StockMarket
{

    public partial class FormLive : Form
    {
        
        private int numberOfCalls = 0;

        
        public FormLive()
        {
            InitializeComponent();
            InitUserControlLiveData();
        }

        private void InitUserControlLiveData()
        {
            OptionChain AllOptions = new OptionChain();
            foreach(OptionSymbol optionSymbol in AllOptions.AllOptionsChain)
            {
                UserControlLiveData temp = new UserControlLiveData();
                temp.SymbolName = optionSymbol.SymbolName;
                temp.StrikePrice = optionSymbol.StrikePrice;
                temp.DaysToApply = ( optionSymbol.EnforcementDate.Date- DateTime.Now.Date).Days;
                temp.Url = AllOptions.BaseLimit + optionSymbol.TseId;
                temp.UrlBase = AllOptions.Closing + optionSymbol.TseBaseSymbolId;
                temp.liveDataWorker = new OptionLiveData();

                temp.UpdateData();
                temp.StartLoop();
                flowLayoutPanel1.Controls.Add(temp);                
            }
           // panelContainer.Controls[0].
            //userControlLiveData1.SymbolName = "ضستا2018";
            //userControlLiveData1.SymbolBaseName = "شستا";
            //userControlLiveData1.BasePrice = "10";
            //userControlLiveData1.SellPrice = "11";
            //userControlLiveData1.BuyPrice = "12";
            //userControlLiveData1.StrikePrice = "13";
            //userControlLiveData1.DaysToApply = "14";
            //userControlLiveData1.ProfitInPercent = "15";
            //userControlLiveData1.Url = Zasta2018BestLimits;
            //userControlLiveData1.UrlBase = "";
            //userControlLiveData1.liveDataWorker = new OptionLiveData(userControlLiveData1.Url);
            //userControlLiveData1.UpdateData();
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(836, 462);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FormLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormLive";
            this.Text = "FormRatio";
            this.ResumeLayout(false);

        }
    }


}
