using Application.DTOs;
using Application.IRepositories;
using Domain;
using HotelListing.Core.Repository;
using Microsoft.EntityFrameworkCore;
using Presistance;

namespace Application.Repositories
{
    public class CategoryRepository : _GenericRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<CategoriesDTO>> GetCategoriesAsync()
        {
            var categories = await _context.Categories.Select(x => new CategoriesDTO
            {
                CategoryId = x.Id, 
                CategoryName = x.Name,
            }).ToListAsync();
            return categories;
        }
    }
}
