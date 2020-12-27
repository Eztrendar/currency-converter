using Currency.Converter.Application.Services;
using Currency.Converter.Model.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Currency.Converter.Application
{
    public static class ApplicationDependencyInjectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICurrencyDownloaderService, CurrencyDownloaderService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
        }
    }
}
