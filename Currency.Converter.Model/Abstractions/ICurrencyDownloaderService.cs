using Currency.Converter.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Converter.Model.Abstractions
{
    public interface ICurrencyDownloaderService
    {
        Task<IEnumerable<CurrencyModel>> DownloadCurrenciesLatestValues();
        Task DownloadCurrenciesAtDate(DateTime date);
    }
}
