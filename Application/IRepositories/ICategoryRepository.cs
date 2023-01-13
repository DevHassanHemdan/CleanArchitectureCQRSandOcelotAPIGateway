using Application.DTOs;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface ICategoryRepository : _IGenericRepository<Categories>
    {
        Task<List<CategoriesDTO>> GetCategoriesAsync();
    }
}
