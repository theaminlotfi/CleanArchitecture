#nullable disable

using Domain.Common;

namespace Domain.Entites;

public class Product : BaseEntity<int>
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public bool IsActive { get; set; }
    // Foreign Key
    public int CategoryId { get; set; }
    // Navigation property
    public Category Category { get; set; }

    private Product() { }

    public Product(int productId, string name, string description, int quantity, bool isActive, int categoryId, Category category)
    {
        ProductId = productId;
        Name = name;
        Description = description;
        Quantity = quantity;
        IsActive = isActive;
        CategoryId = categoryId;
        Category = category;
    }
}
