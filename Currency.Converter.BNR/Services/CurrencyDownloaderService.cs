using Currency.Converter.Model.Entities;
using Currency.Converter.Model.Abstractions;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Currency.Converter.BNR
{
    public class CurrencyDownloaderService : ICurrencyDownloaderService
    {
        public CurrencyDownloaderService()
        {

        }


        public async Task<IEnumerable<CurrencyModel>> DownloadCurrenciesLatestValues()
        {
            return await GetCurrencies(null);
        }

        public Task DownloadCurrenciesAtDate(DateTime date)
        {
            throw new NotImplementedException();
        }
        
        private async Task<IEnumerable<CurrencyModel>> GetCurrencies(DateTime? date)
        {
            var downloadLink = new Uri("https://www.bnr.ro/nbrfxrates.xml");//TODO use this from IConfig and save it in appsettings
            string xmlValues;
            using (var webClient = new WebClient())
            {
                xmlValues = await webClient.DownloadStringTaskAsync(downloadLink);
            }
            var xmlDoc = XDocument.Parse(xmlValues);

            var currencies =  xmlDoc.Root.Elements().FirstOrDefault(el => el.Name.LocalName == "Body")?.
                                Elements().FirstOrDefault(el => el.Name.LocalName == "Cube")?.
                                Elements().Select((element, index) => 
                                    new CurrencyModel
                                    {  
                                        Type = element.Attribute("currency").Value, 
                                        Value = decimal.TryParse(element.Value, out decimal result) ? result : 0 
                                    });
            

            return currencies;
            
        }
    }
}
