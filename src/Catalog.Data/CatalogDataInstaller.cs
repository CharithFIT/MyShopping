using Catalog.Data.Data;
using Catalog.Data.Repositories;
using Catalog.Data.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data
{
    public static class CatalogDataInstaller
    {
        public static IServiceCollection InstallCatalogData(this IServiceCollection services, IConfiguration configuration)
        {
            services.InstallCatalogContext();
            services.InstallRepositories();
            services.InstallSettings(configuration);

            return services;
        }
    }
}
