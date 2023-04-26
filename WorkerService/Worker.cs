using WorkerService.Domain.Crawler;
using WorkerService.Domain.Crawler.Vagas.Indeed;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly CrawlerExe _crawler;
        public Worker(ILogger<Worker> logger, CrawlerExe crawlerExe)
        {
            _logger = logger;
            _crawler = crawlerExe;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            
            while (!stoppingToken.IsCancellationRequested)
            {
                
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}