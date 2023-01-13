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
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand,CategoriesDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CategoriesDTO> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Categories category = _mapper.Map<Categories>(request._categoryDTO);
                await _unitOfWork.Repository<Categories>().CreateAsync(category);
                await _unitOfWork.SaveAsync();
                CategoriesDTO categoryDto = _mapper.Map<CategoriesDTO>(category);
                return categoryDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
