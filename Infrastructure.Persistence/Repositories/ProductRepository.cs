#nullable disable

using Application.Interfaces.Repositories;
using Domain.Entites;
using System.Linq.Expressions;

namespace Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    public Task<bool> AddAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Product>> FindByCondition(Expression<Func<Product, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Product>> GetProductsByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }
}
