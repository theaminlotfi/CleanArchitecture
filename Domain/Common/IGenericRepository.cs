using System.Linq.Expressions;

namespace Domain.Common;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IList<TEntity>> GetAllAsync();
    Task<IList<TEntity>> FindByCondition(Expression<Func<TEntity, bool>> expression);
    Task<TEntity> GetByIdAsync(int id);
    Task<bool> AddAsync(TEntity entity);
    Task<bool> UpdateAsync(TEntity entity);
    Task<bool> DeleteAsync(TEntity entity);
    Task<bool> SaveAsync();
}
