using ProductManagement.Application.Contracts.Products;

namespace ProductManagement.Application.Contracts.Categories
{
    [Serializable]
    public class CategoryDto: BaseEntityDto<Guid>
    {
        //public CategoryDto()
        //{
        //    Products = new HashSet<ProductDto>();
        //}
        public string Name { get; set; }
       //public ICollection<ProductDto> Products { get; private set; }
    }
}
