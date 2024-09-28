using System.ComponentModel.DataAnnotations;

namespace CleanArchWithSolidPrincipal.Application.DTOs
{
    public record UpdateProductDTO
    (
        int Id,
        [Required] string Name,
        [Required] decimal Price,
        [Required] int Stock
    );
}
