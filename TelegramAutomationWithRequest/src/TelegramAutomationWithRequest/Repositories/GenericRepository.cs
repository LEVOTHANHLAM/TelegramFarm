using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using System.Linq.Expressions;
using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Repositories.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TelegramAutomationWithRequest.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }
        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
        }

        public async Task CreateListAsync(IEnumerable<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
        }
        public void CreateList(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().AddRange(entities);
        }
        public Task UpdateAsync(T entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Unchanged)
            {
                return Task.CompletedTask;
            }
            _dbContext.Set<T>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
        public void Update(T entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Unchanged)
            {
                return;
            }
            _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
        }

        public Task UpdateListAsync(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().UpdateRange(entities);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }
        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
        }
        public Task DeleteListAsync(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
            return Task.CompletedTask;
        }
        public void DeleteList(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
        }

        public IQueryable<T> FindAll(bool trackChanges = false) =>
           !trackChanges ? _dbContext.Set<T>().AsNoTracking() :
               _dbContext.Set<T>();

        public IQueryable<T> FindAll(bool trackChanges = false, params Expression<Func<T, object>>[] includeProperties)
        {
            var items = FindAll(trackChanges);
            items = includeProperties.Aggregate(items, (current, includeProperty) => current.Include(includeProperty));
            return items;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges = false) =>
            !trackChanges
                ? _dbContext.Set<T>().Where(expression).AsNoTracking()
                : _dbContext.Set<T>().Where(expression);

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges = false, params Expression<Func<T, object>>[] includeProperties)
        {
            var items = FindByCondition(expression, trackChanges);
            items = includeProperties.Aggregate(items, (current, includeProperty) => current.Include(includeProperty));
            return items;
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> FindByConditionList(Expression<Func<T, bool>> expression, bool trackChanges = false) =>
            !trackChanges
                ? await _dbContext.Set<T>().Where(expression).AsNoTracking().ToListAsync()
                : await _dbContext.Set<T>().Where(expression).ToListAsync();
        public async Task<IEnumerable<T>> FindByConditionList(Expression<Func<T, bool>> expression, bool trackChanges = false, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _dbContext.Set<T>().Where(expression);

            if (trackChanges)
            {
                query = query.AsQueryable();
            }
            else
            {
                query = query.AsNoTracking();
            }
            // Eagerly load related entities based on the specified includeProperties
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.ToListAsync();
        }
    }
}
