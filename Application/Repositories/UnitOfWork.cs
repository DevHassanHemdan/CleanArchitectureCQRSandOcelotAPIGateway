using Application.IRepositories;
using Domain;
using HotelListing.Core.Repository;
using Presistance;

namespace Application.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public DataContext _context { get; set; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        
        public _IGenericRepository<T> Repository<T>() where T : BaseClass
        {
            return new _GenericRepository<T>(_context);
        }
    }
}
