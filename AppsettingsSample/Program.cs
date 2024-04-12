using AppConfigSample;
using AppsettingsSample;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.Configure<MyConfiguration>(builder.Configuration.GetSection("MyConfiguration"));
builder.Services.AddHostedService<MyService>();

IHost host = builder.Build();
await host.RunAsync();
