using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManagement.Categories;
using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.EntityFrameworkCore.Configurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public async void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(ProductConsts.TableName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(ProductConsts.NameMaxLength).IsRequired();
            builder.Property(x => x.Barcode).HasMaxLength(ProductConsts.BarcodeMaxLength).IsRequired();
            builder.Property(x => x.Weight).HasPrecision(18, 2).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreationTime).ValueGeneratedOnAdd();
            builder.Property(x => x.LastModificationTime).ValueGeneratedOnUpdate();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            builder.HasIndex(x => x.Status);
            builder.HasData(
                new Product() 
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-1",
                    Barcode = "123456789",
                    Description = "Descrition-1",
                    Weight = 10,
                    Status = ProductStatus.InStock,
                    CategoryId= Guid.Parse("6866AE00-820D-EC66-9C60-3A0F48228716"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-2",
                    Barcode = "123456789",
                    Description = "Descrition-2",
                    Weight = 10,
                    Status = ProductStatus.InStock,
                    CategoryId = Guid.Parse("6866AE00-820D-EC66-9C60-3A0F48228716"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-3",
                    Barcode = "123456789",
                    Description = "Descrition-3",
                    Weight = 10,
                    Status = ProductStatus.InStock,
                    CategoryId = Guid.Parse("6866AE00-820D-EC66-9C60-3A0F48228716"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-4",
                    Barcode = "123456789",
                    Description = "Descrition-4",
                    Weight = 10,
                    Status = ProductStatus.InStock,
                    CategoryId = Guid.Parse("6866AE00-820D-EC66-9C60-3A0F48228716"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-5",
                    Barcode = "123456789",
                    Description = "Descrition-5",
                    Weight = 10,
                    Status = ProductStatus.InStock,
                    CategoryId = Guid.Parse("6866AE00-820D-EC66-9C60-3A0F48228716"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-6",
                    Barcode = "123456789",
                    Description = "Descrition-6",
                    Weight = 10,
                    Status = ProductStatus.InStock,
                    CategoryId = Guid.Parse("A8452E0C-40B2-DF77-0408-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-7",
                    Barcode = "123456789",
                    Description = "Descrition-7",
                    Weight = 10,
                    Status = ProductStatus.InStock,
                    CategoryId = Guid.Parse("A8452E0C-40B2-DF77-0408-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-8",
                    Barcode = "123456789",
                    Description = "Descrition-8",
                    Weight = 10,
                    Status = ProductStatus.Damaged,
                    CategoryId = Guid.Parse("A8452E0C-40B2-DF77-0408-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-9",
                    Barcode = "123456789",
                    Description = "Descrition-9",
                    Weight = 10,
                    Status = ProductStatus.Damaged,
                    CategoryId = Guid.Parse("A8452E0C-40B2-DF77-0408-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-10",
                    Barcode = "123456789",
                    Description = "Descrition-10",
                    Weight = 10,
                    Status = ProductStatus.Damaged,
                    CategoryId = Guid.Parse("A8452E0C-40B2-DF77-0408-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-11",
                    Barcode = "123456789",
                    Description = "Descrition-11",
                    Weight = 10,
                    Status = ProductStatus.Damaged,
                    CategoryId = Guid.Parse("C72BF8DD-DAB6-D187-048C-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-12",
                    Barcode = "123456789",
                    Description = "Descrition-12",
                    Weight = 10,
                    Status = ProductStatus.Damaged,
                    CategoryId = Guid.Parse("C72BF8DD-DAB6-D187-048C-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-13",
                    Barcode = "123456789",
                    Description = "Descrition-13",
                    Weight = 10,
                    Status = ProductStatus.Damaged,
                    CategoryId = Guid.Parse("C72BF8DD-DAB6-D187-048C-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-14",
                    Barcode = "123456789",
                    Description = "Descrition-14",
                    Weight = 10,
                    Status = ProductStatus.Damaged,
                    CategoryId = Guid.Parse("C72BF8DD-DAB6-D187-048C-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-15",
                    Barcode = "123456789",
                    Description = "Descrition-15",
                    Weight = 10,
                    Status = ProductStatus.Sold,
                    CategoryId = Guid.Parse("C72BF8DD-DAB6-D187-048C-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-16",
                    Barcode = "123456789",
                    Description = "Descrition-16",
                    Weight = 10,
                    Status = ProductStatus.Sold,
                    CategoryId = Guid.Parse("C0B86591-0A77-BE3A-0A64-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-17",
                    Barcode = "123456789",
                    Description = "Descrition-17",
                    Weight = 10,
                    Status = ProductStatus.Sold,
                    CategoryId = Guid.Parse("C0B86591-0A77-BE3A-0A64-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-18",
                    Barcode = "123456789",
                    Description = "Descrition-18",
                    Weight = 10,
                    Status = ProductStatus.Sold,
                    CategoryId = Guid.Parse("C0B86591-0A77-BE3A-0A64-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-19",
                    Barcode = "123456789",
                    Description = "Descrition-19",
                    Weight = 10,
                    Status = ProductStatus.Sold,
                    CategoryId = Guid.Parse("C0B86591-0A77-BE3A-0A64-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product-20",
                    Barcode = "123456789",
                    Description = "Descrition-20",
                    Weight = 10,
                    Status = ProductStatus.Sold,
                    CategoryId = Guid.Parse("C0B86591-0A77-BE3A-0A64-3A0F48228717"),
                    CreationTime = DateTime.UtcNow
                }
           );
        }
    }
}
