using WorkerService;
using WorkerService.Domain.Crawler;
using WorkerService.Domain.Crawler.Interface;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<ICrawler>();
        services.AddSingleton<CrawlerExe>();
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
