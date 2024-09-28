using CleanArchWithSolidPrincipal.Application.DTOs;
using CleanArchWithSolidPrincipal.Application.MappingInterface;
using CleanArchWithSolidPrincipal.Domain.Entities;

namespace CleanArchWithSolidPrincipal.Application.MappingImplementation
{
    public class ProductMapper : IProductMapper
    {
        public ListProductDTO MapToDto(Product product)
        {
            return new ListProductDTO(product.Id, product.Name, product.Price, product.Stock);
        }

        public Product MapToEntity(CreateProductDTO createProductDTO)
        {
            return new Product
            {
                Name = createProductDTO.Name,
                Price = createProductDTO.Price,
                Stock = createProductDTO.Stock
            };
        }

        public Product MapToEntity(UpdateProductDTO updateProductDTO)
        {
            return new Product
            {
                Id = updateProductDTO.Id,
                Name = updateProductDTO.Name,
                Price = updateProductDTO.Price,
                Stock = updateProductDTO.Stock
            };
        }
    }
}
