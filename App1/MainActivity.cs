using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Widget;
using AndroidX.Core.Content;
using Android.Content.PM;
using Android;
using AndroidX.Core.App;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.Threading;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button buttonPrice;
        Button buttonSms;
        TextView text1;
        MainJob mainJob;
        private int NumberOfTextViewUpdates = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            initComponents();
        }

        private void initComponents()
        {
            mainJob = new MainJob(this);

            buttonPrice = FindViewById<Button>(Resource.Id.buttonPrice);
            buttonPrice.Text = "Start Update Price";
            buttonPrice.Click += ButtonPriceClick;

            buttonSms = FindViewById<Button>(Resource.Id.buttonSms);
            buttonSms.Text = "Start Send Sms";
            buttonSms.Click += ButtonSmsClick;

            text1 = FindViewById<TextView>(Resource.Id.text1);

            Thread textViewUpdatesTread = new Thread(() => runTextViewUpdate());
            textViewUpdatesTread.Start();
        }

        private async Task runTextViewUpdate()
        {
            try
            {
                while (true)
                {
                    NumberOfTextViewUpdates++;
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        text1.Text = "view: " + NumberOfTextViewUpdates.ToString() + ", Price: "+MainJob.ShastaPrice+" ," + MainJob.NubmerOfPriceUpdates.ToString() + ", Sms: " + MainJob.NumberOfSentSms.ToString();
                    });
                   
                    Thread.Sleep(100);
                }
            }
            catch(Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }
        }
        
        private void ButtonPriceClick(object sender,EventArgs e)
        {
            try
            {

                if (mainJob.IsRunningPrice)
                {
                    buttonPrice.Text = "Start Update Price";
                    mainJob.StopPrice();
                }
                else
                {
                    buttonPrice.Text = "Stop Update Price";
                    mainJob.StartPrice();
                }
            }
            catch(Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }
        }

        private void ButtonSmsClick(object sender, EventArgs e)
        {
            try
            {

                if (mainJob.IsRunningSms)
                {
                    buttonSms.Text = "Start Send Sms";
                    mainJob.StopSms();
                }
                else
                {
                    buttonSms.Text = "Stop Send Sms";
                    mainJob.StartSms();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}
