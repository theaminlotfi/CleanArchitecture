#nullable disable

using Domain.Common;

namespace Domain.Entites;

public class Category : BaseEntity<int>
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }

    private Category() { }

    public Category(int categoryId, string name, ICollection<Product> products)
    {
        CategoryId = categoryId;
        Name = name;
        Products = products;
    }
}
