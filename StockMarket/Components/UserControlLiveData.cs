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
        public double BasePrice { get; set; }
        public double SellPrice { get; set; }
        public double BuyPrice { get; set; }
        public double StrikePrice { get; set; }
        public int DaysToApply { get; set; }
        public double ProfitInPercent { get; set; }
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
            labelSellPrice.Text = SellPrice.ToString();
            labelBuyPrice.Text = BuyPrice.ToString();
            labelStrikePrice.Text = StrikePrice.ToString();
            labelBasePrice.Text = BasePrice.ToString();
            labelDaysToApply.Text = DaysToApply.ToString();
            labelProfitInPercent.Text = ProfitInPercent.ToString();
            labelMessage.Text = _message;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

            if (isRunning){ StopLoop();}
            else  {StartLoop();}
        }

        public void StopLoop()
        {
            isRunning = false;
            buttonRun.Text = "Start";
        }

        public void StartLoop()
        {
            isRunning = true;
            buttonRun.Text = "Stop";
            Thread loopTread = new Thread(() => runAsync());
            loopTread.Start();
        }

        private async Task runAsync()
        {
            while (isRunning)
            {
                //TODO get live data from internet and update view
                try
                {
                    LiveDataResponse liveDataResponse = await liveDataWorker.GetDataAsync();
                    if (liveDataResponse.IsResultOk)
                    {
                        BuyPrice = liveDataResponse.Orders.bestLimits[0].pMeDem;
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

                }
                catch (Exception ex)
                {
                    _message = ex.Message;
                    labelSymbol.Invoke((MethodInvoker)delegate
                    {
                        UpdateData();
                    });
                }
                
                Thread.Sleep(2000);
            }

        }
    }
}
