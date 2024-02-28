using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace TelegramAutomationWithRequest.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        void Create(T entity);
        Task CreateListAsync(IEnumerable<T> entities);
        void CreateList(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        void Update(T entity);
        Task UpdateListAsync(IEnumerable<T> entities);
        Task DeleteAsync(T entity);
        void Delete(T entity);
        Task DeleteListAsync(IEnumerable<T> entities);
        //Task<int> SaveChangesAsync();
        void DeleteList(IEnumerable<T> entities);

        IQueryable<T> FindAll(bool trackChanges = false);
        IQueryable<T> FindAll(bool trackChanges = false, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges = false);

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges = false,
            params Expression<Func<T, object>>[] includeProperties);
        Task<IEnumerable<T>> FindByConditionList(Expression<Func<T, bool>> expression, bool trackChanges = false);
        Task<IEnumerable<T>> FindByConditionList(Expression<Func<T, bool>> expression, bool trackChanges = false,
            params Expression<Func<T, object>>[] includeProperties);
        Task<T?> GetByIdAsync(object id);
    }
}
