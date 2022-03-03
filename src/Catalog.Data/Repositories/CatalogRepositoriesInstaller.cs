using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.Repositories
{
    public static class CatalogRepositoriesInstaller
    {
        public static IServiceCollection InstallRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();

            return services;
        }

    }
}
