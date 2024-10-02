using Domain.Entities.Common;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task AddEntity(T entity);

        Task DeleteEntity(T entity);

        Task UpdateEntity(T entity);

        Task<ICollection<T>> GetAllEntitiesAsync();

        Task<ICollection<T>> GetEntitiesByAsync(Expression<Func<T, bool>> predicate);

        Task<T?> GetEntityByIdAsync(Guid id);

        Task<T?> GetEntityByAsync(Expression<Func<T, bool>> predicate);

        Task<bool> IsEntityExist(Guid id);
        Task SaveChangesAsync();
    }
}
