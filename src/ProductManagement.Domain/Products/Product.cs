using ProductManagement.Domain;
using ProductManagement.Categories;

namespace ProductManagement.Products
{
    public class Product: BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Weight { get; set; }
        public ProductStatus Status { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
