using Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Concreate.EntityFramework.Contexts;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Repositories
{
    public static class RepositoriesServiceRegistration
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(op => op.UseSqlServer(configuration.GetConnectionString("BaseDB")));

            services.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(x => x.ServiceType.Name.EndsWith("Repository"));
        
            return services;
        }

        
    }
}
