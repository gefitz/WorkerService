using EasyAutomationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.Domain.BotCandidatura.TrabalhaBrasil
{
    public class BotTBR
    {
        private Web _chrome;

        public BotTBR(Web chrome)
        {
            _chrome = chrome;
        }
        public void ExecuteNavigate(string url)
        {
            _chrome.StartBrowser(TypeDriver.GoogleChorme);
            _chrome.Navigate(url);

            _chrome.Click(TypeElement.Xpath, "//div[7]/button");
            _chrome.CloseBrowser();
        }
    }
}
