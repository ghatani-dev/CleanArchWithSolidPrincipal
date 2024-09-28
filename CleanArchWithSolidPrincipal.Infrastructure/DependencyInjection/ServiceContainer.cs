using CleanArchWithSolidPrincipal.Domain.RepositoryInterface;
using CleanArchWithSolidPrincipal.Infrastructure.Data;
using CleanArchWithSolidPrincipal.Infrastructure.RepositoryImplementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchWithSolidPrincipal.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection 
            AddInfrastructureService(this IServiceCollection services
            ,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
