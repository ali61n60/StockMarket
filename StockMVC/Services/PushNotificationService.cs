using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace StockMVC.Services
{
    public class PushNotificationService : IHostedService
    {
        private Timer _timer;

        

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

        public void SendMessage(Object state)
        {
            //Console.WriteLine("called from repeating task at "+DateTime.Now.ToLongTimeString());
            Debug.WriteLine("called from repeating task at " + DateTime.Now.ToLongTimeString());
        }

        
    }
}
