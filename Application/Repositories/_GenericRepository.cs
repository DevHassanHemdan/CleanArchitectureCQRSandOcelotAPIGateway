using Application.IRepositories;
using Application.Specifications;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Presistance;
using System.Linq.Expressions;

namespace HotelListing.Core.Repository
{
    public class _GenericRepository<T> : _IGenericRepository<T> where T : BaseClass
    {
        public DataContext _context;
        public  DbSet<T> _db;

        public _GenericRepository(DataContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _db.Remove(entity);
        }

        public void DeleteRangeAsync(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _db;
            if (include != null)
            {
                query = include(query);
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (include != null)
            {
                query = include(query);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _db.AddAsync(entity);
            return entity;
        }

        public async Task InsertRangeAsync(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void UpdateAsync(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsyncWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec) 
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);  
        }
    }
}