using FizzBuzz.App;
using FizzBuzz.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<ITransformer, Fizz>();
        services.AddTransient<ITransformer, Buzz>();
        services.AddTransient<ITransformationService, TransformationService>();   
        services.AddTransient<IRunner, Printer>();   
    })
    .Build();

var app = host.Services.GetService<IRunner>();
if(app is null)
{
    throw new NullReferenceException("app is null. This mean that the IRunner service is not registered.");
}

app.Run();

await host.RunAsync();