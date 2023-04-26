using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.Domain.Crawler.Interface
{
    public interface ICrawler
    {
        public KeyValuePair<string, List<string>> Vagas();
        public KeyValuePair<string, List<string>> Candidatura(KeyValuePair<string,List<string>> vagas);
    }
}
