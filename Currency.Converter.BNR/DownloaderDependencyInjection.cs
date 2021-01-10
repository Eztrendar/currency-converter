using Currency.Converter.Model.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Currency.Converter.BNR
{
    public static class DownloaderDependencyInjection
    {
        public static void AddDownloaderServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICurrencyDownloaderService, CurrencyDownloaderService>();
        }
    }
}
