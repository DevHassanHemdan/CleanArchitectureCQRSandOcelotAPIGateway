using Application.DTOs;
using Domain;
using MediatR;

namespace Application.CQRS.Queries
{
    public class GetCurrentUserQuery : IRequest<UserDTO>
    {
    }
}
