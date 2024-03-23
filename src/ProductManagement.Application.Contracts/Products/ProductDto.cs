using ProductManagement.Application.Contracts.Categories;
using ProductManagement.Products;

namespace ProductManagement.Application.Contracts.Products
{
    [Serializable]
    public class ProductDto: BaseEntityDto<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Weight { get; set; }
        public string Status { get; set; }
        public CategoryDto Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
