using Application.CQRS.Commands;
using Application.IRepositories;
using Domain;
using MediatR;

namespace Application.CQRS.CommandsHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.Repository<Product>().DeleteAsync(request.ProductId);
            return await _unitOfWork.SaveAsync();
        }
    }
}
