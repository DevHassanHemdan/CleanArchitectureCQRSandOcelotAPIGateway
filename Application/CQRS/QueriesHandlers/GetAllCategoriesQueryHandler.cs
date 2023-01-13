using Application.CQRS.Queries;
using Application.IRepositories;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using Application.DTOs;

namespace Application.CQRS.QueriesHandlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<CategoriesDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ICategoryRepository _ICategoryRepository { get; set; }
        public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork, ICategoryRepository iCategoryRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _ICategoryRepository = iCategoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoriesDTO>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _ICategoryRepository.GetCategoriesAsync();
            //return await _unitOfWork.Repository<Categories>().GetAllAsync();
        }
    }
}
