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
            //services.AddScoped(typeof(IRepository.IRepository<typeof(BaseEntity),int>), typeof(Repository.Repository<typeof(BaseEntity),int>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Element, int>, Repository<Element, int>>();

            return services;
        }
    }
}
