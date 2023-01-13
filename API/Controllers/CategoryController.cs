using Application.CQRS.Commands;
using Application.CQRS.Queries;
using Application.DTOs;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("GetAllCategories")]
       
        public async Task<List<CategoriesDTO>> GetAllCategories()
        {
            var response = await Mediator.Send(new GetAllCategoriesQuery());

            return response;
        }

        [HttpPost("CreateCategory")]
        public async Task<CategoriesDTO> CreateCategory([FromBody] CategoriesDTO categoriesDTO)
        {
            var response = await Mediator.Send(new AddCategoryCommand(categoriesDTO));

            return response;
        }
    }
}
