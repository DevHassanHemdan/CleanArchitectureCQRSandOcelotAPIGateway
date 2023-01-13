using Application.CQRS.Queries;
using Application.IRepositories;
using Domain;
using MediatR;

namespace Application.CQRS.QueriesHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<Product>().GetAllAsync();
        }
    }
}
