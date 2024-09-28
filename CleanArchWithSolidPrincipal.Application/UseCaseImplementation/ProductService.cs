using CleanArchWithSolidPrincipal.Application.DTOs;
using CleanArchWithSolidPrincipal.Application.MappingInterface;
using CleanArchWithSolidPrincipal.Application.UseCaseInterface;
using CleanArchWithSolidPrincipal.Domain.RepositoryInterface;

namespace CleanArchWithSolidPrincipal.Application.UseCaseImplementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductMapper _productMapper;
        public ProductService(IProductRepository productRepository, IProductMapper productMapper)
        {
            _productRepository = productRepository;
            _productMapper = productMapper;
        }

        public async Task AddProductAsync(CreateProductDTO productDto)
        {
            var product = _productMapper.MapToEntity(productDto);
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteProductAsync(int id) =>
            await _productRepository.DeleteAsync(id);

        public async Task<IEnumerable<ListProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(product => _productMapper.MapToDto(product)).ToList();
        }

        public async Task<ListProductDTO?> GetProductByIdAsync(int id)
        {
           var product = await _productRepository.GetByIdAsync(id);
            return product == null ? null : _productMapper.MapToDto(product);
        }

        public async Task UpdateProductAsync(UpdateProductDTO productDto)
        {
            var product = _productMapper.MapToEntity(productDto);
            await _productRepository.UpdateAsync(product);
        }
    }
}
