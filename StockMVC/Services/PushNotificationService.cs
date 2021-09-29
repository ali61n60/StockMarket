using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using StockMVC.Hubs;

namespace StockMVC.Services
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
            // timer repeates call to RemoveScheduledAccounts every 24 hours.
            
            _timer = new Timer(
                SendMessage,
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(2)
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
             await _hubContext.Clients.All.SendAsync("ReceiveMessage", "Server", "called from repeating task at " + DateTime.Now.ToLongTimeString());

            Debug.WriteLine("called from repeating task at " + DateTime.Now.ToLongTimeString());

            
        }

        
    }
}
