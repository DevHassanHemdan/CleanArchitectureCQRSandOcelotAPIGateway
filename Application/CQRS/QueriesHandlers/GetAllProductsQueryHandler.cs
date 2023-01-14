using Application.CQRS.Queries;
using Application.DTOs;
using Application.IRepositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.CQRS.QueriesHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDTO>>
    {
        private readonly IProductRepository _IProductRepository;
        public GetAllProductsQueryHandler(IProductRepository IProductRepository)
        {
            _IProductRepository= IProductRepository;
        }
        public async Task<List<ProductDTO>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _IProductRepository.GetAllProducts();
            return products;
        }
    }
}
