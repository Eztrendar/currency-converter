using Currency.Converter.Model.Abstractions;
using Currency.Converter.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Converter.Application.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyDownloaderService downloaderService;

        //TODO Need to change with an in memory cache
        public CurrencyService(ICurrencyDownloaderService _downloaderService)
        {
            downloaderService = _downloaderService;
        }

        public async Task<IEnumerable<CurrencyModel>> GetLatestCurrencies()
        {
            //TO DO Add get from cache => database and at the end from the downloader service
            return await downloaderService.DownloadCurrenciesLatestValues();
        }
    }
}
