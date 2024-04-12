using AppsettingsSample;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppConfigSample
{
    internal class MyService(IOptions<MyConfiguration> options) : IHostedService
    {
        private readonly string applicationName = options.Value.ApplicationName;

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
