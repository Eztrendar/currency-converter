using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Converter.Model.Abstractions
{
    public interface ICurrencyDownloaderService
    {
        Task DownloadCurrenciesLatestValues();
        Task DownloadCurrenciesAtDate(DateTime date);
    }
}
