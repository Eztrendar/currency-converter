using Currency.Converter.Model.Abstractions;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Currency.Converter.Application.Services
{
    public class CurrencyDownloaderService : ICurrencyDownloaderService
    {
        public CurrencyDownloaderService()
        {

        }


        public async Task<string> DownloadCurrenciesLatestValues()
        {
            return await GetCurrencies(null);
        }

        public Task DownloadCurrenciesAtDate(DateTime date)
        {
            throw new NotImplementedException();
        }
        
        private async Task<string> GetCurrencies(DateTime? date)
        {
            Uri downloadLink = new Uri("https://www.bnr.ro/nbrfxrates.xml");//TODO use this from IConfig and save it in appsettings
            string xmlValues;
            using (var webClient = new WebClient())
            {
                xmlValues = await webClient.DownloadStringTaskAsync(downloadLink);
            }

            return xmlValues;
            //XDocument doc = XDocument.Parse(xmlValues);
        }
    }
}
