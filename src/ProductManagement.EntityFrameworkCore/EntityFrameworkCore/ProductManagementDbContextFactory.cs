
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProductManagement.EntityFrameworkCore.Interceptors;

namespace ProductManagement.EntityFrameworkCore.EntityFrameworkCore
{
    public class ProductManagementDbContextFactory : IDesignTimeDbContextFactory<ProductManagementDbContext>
    {
        public ProductManagementDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProductManagementDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"))
                .AddInterceptors(new SoftDeleteInterceptor());

            return new ProductManagementDbContext(builder.Options);
        }
        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProductManagement.Api/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
