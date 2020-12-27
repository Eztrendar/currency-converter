using System.Threading.Tasks;

namespace Currency.Converter.Model.Abstractions
{
    public interface ICurrencyService
    {
        Task<string> GetLatestCurrencies();
    }
}
