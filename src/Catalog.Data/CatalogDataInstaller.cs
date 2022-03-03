using Catalog.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data
{
    public static class CatalogDataInstaller
    {
        public static IServiceCollection InstallCatalogData(this IServiceCollection services)
        {
            services.InstallCatalogData();
            services.InstallRepositories();

            return services;
        }
    }
}
