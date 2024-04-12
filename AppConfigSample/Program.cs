using AppConfigSample;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<MyService>();

IHost host = builder.Build();
await host.RunAsync();
