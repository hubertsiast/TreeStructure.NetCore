using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TreeStructure.Persistance;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MasterDatabase");
            AddDbContext<TreeStructureDbContext>(services, connectionString);
            services.AddScoped<TreeStructureDbContext>(provider => provider.GetService<TreeStructureDbContext>());
            return services;
        }
        private static void AddDbContext<TContext>(IServiceCollection services, string connectionString) where TContext : DbContext
        {
            services.AddDbContext<TContext>(options =>
                options.UseSqlServer(connectionString,
                    contextOptions => contextOptions.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name))
            );
        }
    }
}