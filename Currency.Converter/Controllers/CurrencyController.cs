using System.Threading.Tasks;
using Currency.Converter.Model.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Currency.Converter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService currencyService;
        public CurrencyController(ICurrencyService _currencyService)
        {
            currencyService = _currencyService;
        }

        [HttpGet("GetLastCurrencies")]
        public async Task<string> GetLastCurrencies()
        {
            return await currencyService.GetLatestCurrencies();
        }
    }
}