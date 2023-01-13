using Application.CQRS.Commands;
using Application.DTOs;
using Application.IRepositories;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Application.CQRS.CommandsHandlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
       
        public AddProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Product product = _mapper.Map<Product>(request._product);
                await _unitOfWork.Repository<Product>().CreateAsync(product);
                await _unitOfWork.SaveAsync();
                ProductDTO productDTO = _mapper.Map<ProductDTO>(product);
                return productDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
