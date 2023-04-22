using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using ModelStd;
using ServiceStd.LiveData;
using StockMVC.Hubs;

namespace StockMVC.PushNotification
{
    public class PushNotificationService : IHostedService
    {
        private Timer _timer;
        private readonly IHubContext<ChatHub> _hubContext;

        public PushNotificationService(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // timer repeats call to RemoveScheduledAccounts every 24 hours.
            
            _timer = new Timer(
                SendMessage,
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(20000)
            );

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public async void SendMessage(Object state)
        {
            //get stock price and send it to users
             string ParsUrl = "http://www.tsetmc.ir/tsev2/data/instinfodata.aspx?i=6110133418282108&c=44+";
             TseLiveData tse = new TseLiveData(ParsUrl);
             LiveDataResponse returnData= await tse.GetPriceAsync();
             string message;
             if (returnData.IsResultOk)
             {
                 message = $"Pars is {returnData.Price} at {DateTime.Now.ToLongTimeString()}";
             }
             else
             {
                 message = $"Error when getting data at {DateTime.Now.ToLongTimeString()}";
             }
             
             await _hubContext.Clients.All.SendAsync("ReceiveMessage", "Server", message);
             Debug.WriteLine("called from repeating task at " + DateTime.Now.ToLongTimeString());
        }
    }
}
