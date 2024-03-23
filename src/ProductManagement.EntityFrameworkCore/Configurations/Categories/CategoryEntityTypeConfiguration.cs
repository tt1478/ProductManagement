using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductManagement.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.EntityFrameworkCore.Configurations.Categories
{
    internal class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(CategoryConsts.TableName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(CategoryConsts.NameMaxLength).IsRequired();
            builder.Property(x => x.CreationTime).ValueGeneratedOnAdd();
            builder.Property(x => x.LastModificationTime).ValueGeneratedOnUpdate();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasData(
                new Category() 
                {
                    Id = Guid.Parse("6866AE00-820D-EC66-9C60-3A0F48228716"),
                    Name = "Category-1",
                    CreationTime = DateTime.UtcNow
                },
                new Category()
                {
                    Id = Guid.Parse("A8452E0C-40B2-DF77-0408-3A0F48228717"),
                    Name = "Category-2",
                    CreationTime = DateTime.UtcNow
                },
                new Category()
                {
                    Id = Guid.Parse("C72BF8DD-DAB6-D187-048C-3A0F48228717"),
                    Name = "Category-3",
                    CreationTime = DateTime.UtcNow
                },
                new Category()
                {
                    Id = Guid.Parse("C0B86591-0A77-BE3A-0A64-3A0F48228717"),
                    Name = "Category-4",
                    CreationTime = DateTime.UtcNow
                },
                new Category()
                {
                    Id = Guid.Parse("F1DC7EEB-85ED-9967-0E32-3A0F48228717"),
                    Name = "Category-5",
                    CreationTime = DateTime.UtcNow
                }
           );
        }
    }
}
