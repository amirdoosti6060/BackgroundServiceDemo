using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

namespace BackgroundServiceDemo
{
    public class Worker : BackgroundService
    {
        public event EventHandler<string>? MessageReceived;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Random rnd = new Random();

            while (!stoppingToken.IsCancellationRequested)
            {
                // Background task logic goes here
                var num = rnd.Next(100);
                OnMessageReceived($"Random number generated in background service: {num}!");

                await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken);
            }
        }

        protected virtual void OnMessageReceived(string message) 
        { 
            MessageReceived?.Invoke(this, message);
        }
    }
}
