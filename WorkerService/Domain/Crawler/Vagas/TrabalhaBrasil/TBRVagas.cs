using EasyAutomationFramework;
using HtmlAgilityPack;
using WorkerService.Domain.BotCandidatura.TrabalhaBrasil;
using WorkerService.Domain.Crawler.Interface;

namespace WorkerService.Domain.Crawler.Vagas.Indeed
{
    public class TBRVagas : ICrawler
    {
        private readonly BotTBR _bot;

        public TBRVagas()
        {
            _bot = new BotTBR(new Web());
        }

        public KeyValuePair<string, List<string>> Vagas()
        {
            List<string> vagas = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                HttpClient client = new HttpClient();
                using (var response = client.GetStringAsync($"https://www.trabalhabrasil.com.br/vagas-empregos/desenvolvedor%20csharp?pagina={i}"))
                {
                    HtmlDocument html = new HtmlDocument();
                    html.LoadHtml(response.Result);
                    var links = html.DocumentNode.SelectNodes(@"//*[@id=""jobs-wrapper""]/div/a");
                    foreach (var link in links)
                    {

                        vagas.Add(link.Attributes["href"].Value);
                    }

                }
            }
            return new KeyValuePair<string, List<string>>("TBRVagas", vagas);
        }
        public KeyValuePair<string, List<string>> Candidatura(KeyValuePair<string, List<string>> vagas)
        {
            if (vagas.Key == "TBRVagas")
            {
                for (int i = 0; i <= vagas.Value.Count;i++)
                {
                    _bot.ExecuteNavigate(vagas.Value[i]);
                }    
            }
            return new KeyValuePair<string, List<string>>("",null);
        }
    }
}
