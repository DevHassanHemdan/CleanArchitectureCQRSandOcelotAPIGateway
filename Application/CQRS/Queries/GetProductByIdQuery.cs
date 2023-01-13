using Domain;
using MediatR;

namespace Application.CQRS.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public Guid ProductId { get; set; }
        public GetProductByIdQuery(Guid productId)
        {
            ProductId = productId;
        }
    }
}
