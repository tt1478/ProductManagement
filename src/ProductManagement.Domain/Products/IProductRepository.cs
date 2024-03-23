using ProductManagement.Domain.Shared.Products;
using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Products
{
    public interface IProductRepository: IRepository
    {
        Task<List<Product>> GetListAsync();
        Task<List<Product>> GetByStatusAsync(ProductStatus? status);
        Task<List<ProductCountByStatusDto>> GetProductCountByStatusAsync();
        Task<bool> UpdateStatusAsync(Guid id, ProductStatus status);
        Task<bool> SellProductAsync(Guid id);
    }
}
