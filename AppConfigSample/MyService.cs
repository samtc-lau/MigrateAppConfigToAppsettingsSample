using AppConfigSample.Properties;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppConfigSample
{
    internal class MyService : IHostedService
    {
        private readonly string applicationName = Settings.Default.ApplicationName;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"{applicationName} starts");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"{applicationName} stops");
            return Task.CompletedTask;
        }
    }
}
