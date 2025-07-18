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
        
        

        public static int NumberOfSentSms = 0;
        public static int NubmerOfPriceUpdates = 0;
        public static string ShastaPrice = "0";
        private string timeOfPriceUpdate="1.1";
        //private readonly string Url = "http://old.tsetmc.com/tsev2/data/instinfofast.aspx?i=2400322364771558&c=39%2";
        private readonly string Url = "https://cdn.tsetmc.com/api/BestLimits/2400322364771558";
        private ILiveDataWorker liveDataWorker= new TseLiveData();

        private Thread updatePriceThread;
        public bool IsRunningPrice = false;

        private Thread sendSmsTread;
        public bool IsRunningSms = false;

        private Context context;

        public MainJob(Context co)
        {
            context = co;
        }

        public void StartPrice()
        {
            updatePriceThread = new Thread(() => runUpdatePriceAsync());
           
            IsRunningPrice = true;
            updatePriceThread.Start();
        }

        public void StartSms()
        {
            sendSmsTread = new Thread(() => runSendSmsAsync());            

            IsRunningSms = true;
            sendSmsTread.Start();
        }

        private async Task runUpdatePriceAsync()
        {
            while (IsRunningPrice)
            {
                try
                {
                    BestLimitsResponse bestLimitsResponse = await liveDataWorker.GetBestLimitsAsync(Url);
                    if (bestLimitsResponse.IsResultOk)
                    {
                        //pMeDem":1296.000,"pMeOf":1297.000
                        ShastaPrice= bestLimitsResponse.bestLimits.bestLimits[0].pMeDem.ToString();

                        NubmerOfPriceUpdates++;
                        timeOfPriceUpdate = DateTime.Now.ToShortTimeString();
                        Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                        {
                            Toast.MakeText(context, "Shasta: " + ShastaPrice.ToString(), ToastLength.Long).Show();
                        });
                    }
                    else
                    {
                        Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                        {
                            Toast.MakeText(context, bestLimitsResponse.Message, ToastLength.Long).Show();
                        });
                    }

                    
                    
                }
                catch(Exception ex)
                {
                    Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                    {
                        Toast.MakeText(context, ex.Message, ToastLength.Long).Show();
                    });
                   
                }

                Thread.Sleep(10000); //10 seconds
            }

        }
        
        private async Task runSendSmsAsync()
        {
            while (IsRunningSms)
            {
                try
                {
                    string smsMessage = "Shasta : " + ShastaPrice + " " + timeOfPriceUpdate ;
                    senSms(smsMessage);
                    NumberOfSentSms++;
                    Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                    {
                        Toast.MakeText(context, "Sms Sent: "+ smsMessage, ToastLength.Long).Show();
                    });                   
                }
                catch(Exception ex)
                {
                    Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                    {
                        Toast.MakeText(context, ex.Message, ToastLength.Long).Show();
                    });                    
                }

                Thread.Sleep(600000); //10 minutes
            }
        }
        
        public void StopPrice()
        {
            IsRunningPrice = false;
        }
        public void StopSms()
        {
            IsRunningSms = false;
        }


        private void senSms(string text)
        {
            string number = "09216440148";

            SmsManager manager = SmsManager.Default;
            manager.SendTextMessage(number, null,text, null, null);
        }

    }

   
}