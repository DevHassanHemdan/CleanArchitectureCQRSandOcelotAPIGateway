using Application.Specifications;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.IRepositories
{
    public interface _IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(
             Expression<Func<T, bool>> expression = null,
             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
             Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
          );
        Task<T> GetAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsyncWithSpec(ISpecification<T> spec);
        Task<T> CreateAsync(T entity);
        Task InsertRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(Guid id);
        void DeleteRangeAsync(IEnumerable<T> entities);
        void UpdateAsync(T entity);
        Task<T> Where(Expression<Func<T, bool>> predicate);

    }
}
