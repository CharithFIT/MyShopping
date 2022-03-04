using Catalog.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Service
{
    public static class ServiceInstaller
    {
        public static IServiceCollection InstallServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<IProductService, ProductService>();

            return services;
        }
    }
}
