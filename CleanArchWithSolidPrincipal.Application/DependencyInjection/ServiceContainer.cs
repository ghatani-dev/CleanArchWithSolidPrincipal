using CleanArchWithSolidPrincipal.Application.MappingImplementation;
using CleanArchWithSolidPrincipal.Application.MappingInterface;
using CleanArchWithSolidPrincipal.Application.UseCaseImplementation;
using CleanArchWithSolidPrincipal.Application.UseCaseInterface;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchWithSolidPrincipal.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection
            AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductMapper, ProductMapper>();
            return services;
        }
    }
}
