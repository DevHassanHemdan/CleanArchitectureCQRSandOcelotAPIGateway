using Domain;
using MediatR;

namespace Application.CQRS.Queries
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {
    }
}
