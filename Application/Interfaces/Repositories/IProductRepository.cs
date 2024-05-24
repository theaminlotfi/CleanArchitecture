using Domain.Common;
using Domain.Entites;

namespace Application.Interfaces.Repositories;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IList<Product>> GetProductsByCategoryIdAsync(int categoryId);
}
