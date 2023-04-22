using ModelStd;
using ServiceStd.LiveData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket.Components
{
    public partial class UserControlLiveData : UserControl
    {
        private bool isRunning = false;
        private string _message="ok";
        public string SymbolName { get; set; }  //ضستا
        public string SymbolBaseName { get; set; }  //شستا
        public string BasePrice { get; set; }

        public string SellPrice { get; set; }
        public string BuyPrice { get; set; }
        public string StrikePrice { get; set; }
        public string DaysToApply { get; set; }
        public string ProfitInPercent { get; set; }
        public string Url { get; set; }
        public string UrlBase { get; set; }
        public ILiveDataWorker liveDataWorker { get; set; }
        public UserControlLiveData()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            labelSymbol.Text = SymbolName;
            labelSellPrice.Text = SellPrice;
            labelBuyPrice.Text = BuyPrice;
            labelStrikePrice.Text = StrikePrice;
            labelBasePrice.Text = BasePrice;
            labelDaysToApply.Text = DaysToApply;
            labelProfitInPercent.Text = ProfitInPercent;
            labelMessage.Text = _message;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

            if (isRunning)
            {
                isRunning = false;
                buttonRun.Text = "Start";
            }
            else
            {
                isRunning = true;
                buttonRun.Text = "Stop";
                startLoop();
            }
        }

        private void startLoop()
        {
            Thread loopTread = new Thread(() => runAsync());
            loopTread.Start();
        }

        private async Task runAsync()
        {
            while (isRunning)
            {
                //TODO get live data from internet and update view
                LiveDataResponse liveDataResponse=await liveDataWorker.GetDataAsync();
                if (liveDataResponse.IsResultOk)
                {                    
                    SellPrice = liveDataResponse.LastPrice.ToString();
                    _message = DateTime.Now.ToString();
                }
                else
                {
                    _message = liveDataResponse.Message;
                }
                
                labelSymbol.Invoke((MethodInvoker)delegate
                {
                    UpdateData();
                });

                Thread.Sleep(2000);
            }

        }
    }
}
