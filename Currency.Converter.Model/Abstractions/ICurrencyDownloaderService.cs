using System;
using System.Threading.Tasks;

namespace Currency.Converter.Model.Abstractions
{
    public interface ICurrencyDownloaderService
    {
        Task<string> DownloadCurrenciesLatestValues();
        Task DownloadCurrenciesAtDate(DateTime date);
    }
}
