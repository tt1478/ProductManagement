using AutoMapper;
using ProductManagement.Application.Contracts.Products;
using ProductManagement.Domain.Products;
using ProductManagement.Domain.Shared.Products;
using ProductManagement.Products;


namespace ProductManagement.Application.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(
            IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<List<ProductDto>> GetByStatusAsync(ProductStatus? status)
        {
            var products = await _productRepository.GetByStatusAsync(status);
            return _mapper.Map<List<ProductDto>>(products);
        }
        public async Task<List<ProductDto>> GetListAsync()
        {
            var products = await _productRepository.GetListAsync();
            return _mapper.Map<List<Product>, List<ProductDto>>(products);
        }

        public async Task<List<ProductCountByStatusDto>> GetProductCountByStatusAsync()
        {
            var res = await _productRepository.GetProductCountByStatusAsync();
            return res;
        }

        public async Task<bool> SellProductAsync(Guid id)
        {
            var res = await _productRepository.SellProductAsync(id);
            await _productRepository.SaveChangesAsync();
            return res;
        }

        public async Task<bool> UpdateStatusAsync(Guid id, ProductStatus status)
        {
            var res = await _productRepository.UpdateStatusAsync(id, status);
            await _productRepository.SaveChangesAsync();
            return res;
        }
    }
}
