using Currency.Converter.Model.Abstractions;
using System.Threading.Tasks;

namespace Currency.Converter.Application.Services
{
    public class CurrencyService : ICurrencyService
    {
        ICurrencyDownloaderService downloaderService;
        //TODO Need to change with an in memory cache
        public CurrencyService(ICurrencyDownloaderService _downloaderService)
        {
            downloaderService = _downloaderService;
        }

        public async Task<string> GetLatestCurrencies()
        {
            return await downloaderService.DownloadCurrenciesLatestValues();
        }
    }
}
