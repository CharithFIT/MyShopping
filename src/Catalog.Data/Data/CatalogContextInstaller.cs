using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.Data
{
    public static class CatalogContextInstaller
    {
        public static IServiceCollection InstallCatalogContext(this IServiceCollection services)
        {
            services.AddTransient<ICatalogContext, CatalogContext>();

            return services;
        }
    }
}
