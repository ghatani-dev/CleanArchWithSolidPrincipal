using System.ComponentModel.DataAnnotations;

namespace CleanArchWithSolidPrincipal.Application.DTOs
{
    public record ListProductDTO
    (
        int Id,
        string Name,
        decimal Price,
        int Stock
    );
}
