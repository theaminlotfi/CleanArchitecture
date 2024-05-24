#nullable disable

namespace Application.Dtos.Product;

public record UpdateProductDto
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public bool IsActive { get; set; }
    public int CategoryId { get; set; }
}