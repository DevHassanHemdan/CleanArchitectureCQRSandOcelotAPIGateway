using Application.DTOs;
using Domain;
using MediatR;

namespace Application.CQRS.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<CategoriesDTO>>
    {
    }
}
