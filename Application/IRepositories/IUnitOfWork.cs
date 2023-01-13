using Domain;
using Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IUnitOfWork
    {
        _IGenericRepository<T> Repository<T>() where T : BaseClass;
        Task<int> SaveAsync();
    }
}
