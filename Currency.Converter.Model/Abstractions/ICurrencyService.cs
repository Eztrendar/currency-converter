using Currency.Converter.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Converter.Model.Abstractions
{
    public interface ICurrencyService
    {
        Task<IEnumerable<CurrencyModel>> GetLatestCurrencies();
    }
}
