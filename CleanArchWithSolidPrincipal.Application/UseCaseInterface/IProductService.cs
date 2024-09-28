using CleanArchWithSolidPrincipal.Application.DTOs;

namespace CleanArchWithSolidPrincipal.Application.UseCaseInterface
{
    public interface IProductService
    {
        Task<IEnumerable<ListProductDTO>> GetAllProductsAsync();
        Task<ListProductDTO?> GetProductByIdAsync(int id);
        Task AddProductAsync(CreateProductDTO product);
        Task UpdateProductAsync(UpdateProductDTO product);
        Task DeleteProductAsync(int id);
    }
}
