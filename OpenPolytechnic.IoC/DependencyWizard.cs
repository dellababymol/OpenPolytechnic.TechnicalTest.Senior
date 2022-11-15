using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenPolytechnic.Business.Services;
using OpenPolytechnic.Business.Services.Interfaces;

namespace OpenPolytechnic.IoC
{
    public static class DependencyWizard
    {
        public static void ConfigureDependencies(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureServices(services);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IOrderService, OrderService>();

        }
    }
}
