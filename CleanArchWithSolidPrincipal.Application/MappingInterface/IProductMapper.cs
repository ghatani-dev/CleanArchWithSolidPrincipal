using CleanArchWithSolidPrincipal.Application.DTOs;
using CleanArchWithSolidPrincipal.Domain.Entities;

namespace CleanArchWithSolidPrincipal.Application.MappingInterface
{
    public interface IProductMapper
    {
        ListProductDTO MapToDto(Product product);
        Product MapToEntity(CreateProductDTO createProductDTO);
        Product MapToEntity(UpdateProductDTO updateProductDTO);
    }
}
