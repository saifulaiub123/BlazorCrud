using Microsoft.Extensions.DependencyInjection;
using SOM.Bll.IService;
using SOM.Bll.Service;

namespace SOM.Bll.Dependency
{
    public static class ServiceResolutionConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IElementService, ElementService>();
            services.AddScoped<IElementTypeService, ElementTypeService>();
            services.AddScoped<IWindowService, WindowService>();
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
