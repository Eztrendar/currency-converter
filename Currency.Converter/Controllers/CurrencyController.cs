using System.Collections.Generic;
using System.Threading.Tasks;
using Currency.Converter.Model.Abstractions;
using Currency.Converter.Model.Entities;
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

        [HttpGet("latest")]
        public async Task<IEnumerable<CurrencyModel>> GetLastestCurrencies()
        {
            return await currencyService.GetLatestCurrencies();
        }
    }
}