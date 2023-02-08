using Microsoft.Extensions.DependencyInjection;
using SOM.Core.DBModel;
using SOM.DAL.Repository;
using SOM.DAL.UOF;

namespace SOM.DAL.Dependency
{
    public static class RepositoryResolutionConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Element, int>, Repository<Element, int>>();
            services.AddScoped<IRepository<Window, int>, Repository<Window, int>>();
            services.AddScoped<IRepository<WindowElement, int>, Repository<WindowElement, int>>();
            services.AddScoped<IRepository<Order, int>, Repository<Order, int>>();
            services.AddScoped<IRepository<OrderWindow, int>, Repository<OrderWindow, int>>();

            return services;
        }
    }
}
