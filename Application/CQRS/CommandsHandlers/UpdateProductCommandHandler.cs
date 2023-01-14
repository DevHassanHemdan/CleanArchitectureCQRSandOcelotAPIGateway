using Application.CQRS.Commands;
using Application.DTOs;
using Application.IRepositories;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.CommandsHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ProductDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ProductDTO> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Product product = await _unitOfWork.Repository<Product>().GetAsync(x => x.Id == request._product.Id);
                product.Name = request._product.ProductName;
                product.Price = request._product.Price;
                product.Description = request._product.Description;
                product.CategoryId = request._product.CategoryId;

                _unitOfWork.Repository<Product>().UpdateAsync(product);
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
