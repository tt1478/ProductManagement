using AutoMapper;
using ProductManagement.Application.Contracts.Categories;
using ProductManagement.Application.Contracts.Products;
using ProductManagement.Categories;
using ProductManagement.Products;

namespace ProductManagement.Api
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            //Product
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Status, src => src.MapFrom(x => Enum.GetName(typeof(ProductStatus), x.Status)));

            //Category
            CreateMap<Category, CategoryDto>();
        }
    }
}
