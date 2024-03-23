using Microsoft.EntityFrameworkCore;
using ProductManagement.Categories;
using ProductManagement.EntityFrameworkCore.Configurations;
using ProductManagement.EntityFrameworkCore.Configurations.Categories;
using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.EntityFrameworkCore.EntityFrameworkCore
{
    public class ProductManagementDbContext: DbContext
    {
        #region Entities
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        #endregion
        public ProductManagementDbContext(DbContextOptions<ProductManagementDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        }
    }
}
