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
        public double AskPrice { get; set; }
        public double BidPrice { get; set; }
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
            setProfitInPercent();
            labelSymbol.Text = SymbolName;
            labelAskPrice.Text = "Ask: "+ AskPrice.ToString();
            labelBidPrice.Text = "Bid: "+ BidPrice.ToString();
            labelStrikePrice.Text = "strike: "+StrikePrice.ToString();
            labelBasePrice.Text = "base: "+ BasePrice.ToString();
            labelDaysToApply.Text = "days: "+ DaysToApply.ToString();
            labelProfitInPercent.Text ="profit: "+ ProfitInPercent.ToString();
            labelMessage.Text = _message;
        }

        private void setProfitInPercent()
        {
            try
            {
                double investMoney = BasePrice - AskPrice; //how much invested
                double profit = StrikePrice - investMoney;// sell price - investment
                double profitPercent = profit * 100 / investMoney;//percent
                profitPercent = profitPercent * 31 / DaysToApply; //normalize to per month

                ProfitInPercent = profitPercent;
            }
            catch(Exception ex)
            {
                labelMessage.Text = ex.Message;
            }
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
                    SymbolData symbolData = await liveDataWorker.GetLiveDataAsync(Url);
                    AskPrice = Double.Parse( symbolData.TransactionPrice);
                }
                catch (Exception ex)
                {
                    _message = ex.Message;
                       labelSymbol.Invoke((MethodInvoker)delegate
                       {
                           UpdateData();
                       });
                }
                //try
                //{
                //    BestLimitsResponse liveDataResponse = await liveDataWorker.GetBestLimitsAsync(Url);
                //    if (liveDataResponse.IsResultOk)
                //    {
                //        BidPrice = liveDataResponse.bestLimits.bestLimits[0].pMeDem;
                //        AskPrice = liveDataResponse.bestLimits.bestLimits[0].pMeOf;
                //        _message = DateTime.Now.ToString();
                //    }
                //    else
                //    {
                //        _message = liveDataResponse.Message;
                //    }
                //    ClosingPriceInfoResponse closingPriceInfoResponse = await liveDataWorker.GetClosingPriceInfoAsync(UrlBase);
                //    if (closingPriceInfoResponse.IsResultOk)
                //    {
                //        BasePrice = closingPriceInfoResponse.closingPriceInfo.pDrCotVal;
                //    }
                //    else
                //    {
                //        _message = closingPriceInfoResponse.Message;
                //    }

                //    labelSymbol.Invoke((MethodInvoker)delegate
                //    {
                //        UpdateData();
                //    });

                //}
                //catch (Exception ex)
                //{
                //    _message = ex.Message;
                //    labelSymbol.Invoke((MethodInvoker)delegate
                //    {
                //        UpdateData();
                //    });
                //}

                Thread.Sleep(2000);
            }

        }
    }
}
