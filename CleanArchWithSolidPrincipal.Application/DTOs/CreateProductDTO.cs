using System.ComponentModel.DataAnnotations;

namespace CleanArchWithSolidPrincipal.Application.DTOs
{
    public record CreateProductDTO
    (
        [Required] string Name,
        [Required] decimal Price,
        [Required] int Stock
    );
}
