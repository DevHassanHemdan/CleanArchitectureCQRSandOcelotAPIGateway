using Application.CQRS.Commands;
using Application.CQRS.Queries;
using Application.DTOs;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    //[AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : BaseController
    {
        
        [HttpGet("GetAllProducts")]
        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var response = await Mediator.Send(new GetAllProductsQuery());

            return response;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProductById(Guid productId)
        {
            var response = await Mediator.Send(new GetProductByIdQuery(productId));

            return response;
        }

        [HttpPost("CreateProduct")]
        public async Task<ProductDTO> CreateProduct([FromBody] ProductDTO productDTo)
        {
            var response = await Mediator.Send(new AddProductCommand(productDTo));

            return response;
        }

        [HttpPut("UpdateProduct")]
        public async Task<ProductDTO> UpdateProduct([FromBody] ProductDTO productDTo)
        {
            var response = await Mediator.Send(new UpdateProductCommand(productDTo));

            return response;
        }

        [HttpDelete("DeleteProduct")]
        public async Task<int> DeleteProduct(Guid productId)
        {
            return await Mediator.Send(new DeleteProductCommand(productId));
        }
    }
}