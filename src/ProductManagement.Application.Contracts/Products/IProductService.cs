using ProductManagement.Domain.Shared.Products;
using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Contracts.Products
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetListAsync();
        Task<List<ProductDto>> GetByStatusAsync(ProductStatus? status);
        Task<List<ProductCountByStatusDto>> GetProductCountByStatusAsync();
        Task<bool> UpdateStatusAsync(Guid id, ProductStatus status);
        Task<bool> SellProductAsync(Guid id);
    }
}
