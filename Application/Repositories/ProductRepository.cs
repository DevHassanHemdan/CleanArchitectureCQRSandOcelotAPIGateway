using Application.DTOs;
using Application.IRepositories;
using Domain;
using HotelListing.Core.Repository;
using Microsoft.EntityFrameworkCore;
using Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class ProductRepository : _GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var products = await _context.Products.Select(x => new ProductDTO
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                CreatedBy = x.CreatedBy,
                ProductName = x.Name,
                Description = x.Description,
                Price = x.Price,
                CreatedOn = x.CreatedOn,
                CategoryName = x.Categories.Name
            }).ToListAsync();
            return products;
        }
    }
}
