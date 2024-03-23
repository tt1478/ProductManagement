using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Exceptions;
using ProductManagement.Domain.Products;
using ProductManagement.Domain.Shared.Products;
using ProductManagement.EntityFrameworkCore.EntityFrameworkCore;
using ProductManagement.Products;

namespace ProductManagement.EntityFrameworkCore.Repositories.Products
{
    public class ProductRepository : Repository, IProductRepository
    {
        private readonly ProductManagementDbContext _context;
        public ProductRepository(ProductManagementDbContext context): base(context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetByStatusAsync(ProductStatus? status)
        {
            try 
            {
                var res = new List<Product>();
                if (status.HasValue)
                {
                    res = await _context.Products
                        .Where(x => x.Status == status.Value).Include(x => x.Category).ToListAsync();
                }
                return res;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task<List<Product>> GetListAsync()
        {
            try 
            {
                var products = await _context.Products
                .Include(x => x.Category).ToListAsync();
                return products;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task<List<ProductCountByStatusDto>> GetProductCountByStatusAsync()
        {
            try 
            {
                var products = await _context.Products
                .GroupBy(x => x.Status)
                .Select(x => new ProductCountByStatusDto()
                {
                    Status = x.Key.ToString(),
                    Count = x.Count()
                })
                .ToListAsync();
                return products;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> SellProductAsync(Guid id)
        {
            try 
            {
                var product = await _context.Products
                .Where(x => x.Id == id).FirstOrDefaultAsync();
                if (product == null)
                {
                    throw new EntityNotFoundException<Guid>(id);
                }
                if (product.Status == ProductStatus.InStock)
                {
                    product.Status = ProductStatus.Sold;
                }
                else
                {
                    throw new ProductStatusException<Guid>(id, product.Status);
                }
                return true;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task<bool> UpdateStatusAsync(Guid id, ProductStatus status)
        {
            try 
            {
                var product = await _context.Products
                .Where(x => x.Id == id).FirstOrDefaultAsync();
                if (product == null)
                {
                    throw new EntityNotFoundException<Guid>(id);
                }
                if (product.Status == ProductStatus.Damaged)
                {
                    throw new ProductStatusException<Guid>(id, product.Status);
                }
                else if (product.Status == ProductStatus.Sold)
                {
                    throw new ProductStatusException<Guid>(id, product.Status);
                }
                product.Status = status;
                return true;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
