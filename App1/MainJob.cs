using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Telephony;
using Android.Views;
using Android.Widget;
using ModelStd;
using ServiceStd.LiveData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App1
{
    public class MainJob
    {
        public bool IsRunning = false;
        public static int NumberOfSentSms = 0;
        public static int NubmerOfPriceUpdates = 0;
        public static string ShastaPrice = "0";
        private readonly string Url = "http://old.tsetmc.com/tsev2/data/instinfofast.aspx?i=2400322364771558&c=39%2";
        private ILiveDataWorker liveDataWorker= new TseLiveData();

        public void Start()
        {
            IsRunning = true;
            
            Thread sendSmsTread = new Thread(() => runSendSmsAsync());
            Thread updatePrice = new Thread(() => runUpdatePriceAsync());
           
            sendSmsTread.Start();
            updatePrice.Start();

        }

        private async Task runUpdatePriceAsync()
        {
            while (IsRunning)
            {
                try
                {
                    SymbolData symbolData = await liveDataWorker.GetLiveDataAsync(Url);
                    ShastaPrice = symbolData.TransactionPrice;

                    NubmerOfPriceUpdates++;

                }

                catch(Exception ex)
                {

                }

                Thread.Sleep(30000); //30 seconds
            }

        }
        
        private async Task runSendSmsAsync()
        {
            while (IsRunning)
            {
                try
                {
                    senSms("Shasta : " + ShastaPrice + " " + DateTime.Now.ToShortTimeString());
                    NumberOfSentSms++;
                }
                catch(Exception ex)
                {

                }

                Thread.Sleep(600000); //10 minutes
            }
        }
        
        public void Stop()
        {
            IsRunning = false;
        }
        
                
        private void senSms(string text)
        {
            string number = "09216440148";

            SmsManager manager = SmsManager.Default;
            manager.SendTextMessage(number, null,text, null, null);
        }

    }

   
}