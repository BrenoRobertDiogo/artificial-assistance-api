using IoC.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfiguracaoPersonalizada(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbConfig(configuration);

            return services;
        }
    }
}
