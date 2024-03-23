using ProductManagement.Application.Contracts.Products;
using ProductManagement.Application.Products;
using ProductManagement.Domain;
using ProductManagement.Domain.Products;
using ProductManagement.EntityFrameworkCore.Repositories;
using ProductManagement.EntityFrameworkCore.Repositories.Products;
using System.Runtime.CompilerServices;

namespace ProductManagement.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
