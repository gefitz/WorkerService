using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService.Domain.Crawler.Interface;

namespace WorkerService.Domain.Crawler
{
    public class CrawlerExe
    {
        private readonly ICrawler _crawler;

        public CrawlerExe(ICrawler crawler)
        {
            _crawler = crawler;
        }

        public void Execute()
        {
            var vagas = _crawler.Vagas();
            _crawler.Candidatura(vagas);
        }

    }
}
