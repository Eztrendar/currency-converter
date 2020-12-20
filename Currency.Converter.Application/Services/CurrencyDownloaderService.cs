using Currency.Converter.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Currency.Converter.Application.Services
{
    public class CurrencyDownloaderService : ICurrencyDownloaderService
    {
        public CurrencyDownloaderService()
        {

        }


        public async Task DownloadCurrenciesLatestValues()
        {
            await GetCurrencies(null);
        }

        public Task DownloadCurrenciesAtDate(DateTime date)
        {
            throw new NotImplementedException();
        }
        
        private async Task GetCurrencies(DateTime? date)
        {
            Uri downloadLink = 
            string xmlValues;
            using (var webClient = new WebClient())
            {
                xmlValues = await webClient.DownloadStringAsync("https://www.bnr.ro/nbrfxrates.xml");
            }

            XDocument doc = XDocument.Parse(xmlValues);
        }
    }
}
