using Application.CQRS.Commands;
using Application.CQRS.Queries;
using Application.DTOs;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : BaseController
    {
        
        [HttpGet("GetAllProducts")]
        //[Authorize]
        public async Task<List<Product>> GetAllProducts()
        {
            var response = await Mediator.Send(new GetAllProductsQuery());

            return response;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProductById(Guid id)
        {
            var response = await Mediator.Send(new GetProductByIdQuery(id));

            return response;
        }

        [HttpPost("CreateProduct")]
        public async Task<ProductDTO> CreateProduct([FromBody] ProductDTO productDTo)
        {
            var user = _userManager.GetUserAsync(HttpContext.User);
            var response = await Mediator.Send(new AddProductCommand(productDTo));

            return productDTo;
        }

        [HttpPost("DeleteProduct")]
        public async Task<int> DeleteProduct(Guid productId)
        {
            return await Mediator.Send(new DeleteProductCommand(productId));
        }
    }
}