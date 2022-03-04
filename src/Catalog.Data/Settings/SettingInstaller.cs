using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.Settings
{
    public static class SettingInstaller
    {
        public static IServiceCollection InstallSettings(this IServiceCollection services, IConfiguration configuration) 
        {
            services.Configure<DatabaseSettings>(configuration.GetSection("DatabaseSettings"));

            return services;
        }
    }
}
