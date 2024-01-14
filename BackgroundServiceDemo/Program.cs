using BackgroundServiceDemo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Background Service Demo!");

        IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                // I used here a technique called Singleton Registeration because
                // I need to get access to instance of worker service later to be able to
                // add message handler.
                services.AddSingleton<Worker>();
                services.AddHostedService(provider => provider.GetService<Worker>());
            })
            .Build();

        var worker = host.Services.GetService<Worker>();
        worker.MessageReceived += Worker_MessageReceived;

        host.Run();

        Console.WriteLine("Background Service Demo is terminated!");        
    }

    private static void Worker_MessageReceived(object? sender, string e)
    {
        Console.WriteLine(e);
    }
}