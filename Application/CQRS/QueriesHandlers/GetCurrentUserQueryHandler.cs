using Application.CQRS.Queries;
using Application.DTOs;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.QueriesHandlers
{
    public class GetCurrentUserQueryHandler : IRequestHandler<GetCurrentUserQuery, UserDTO>
    {
        private readonly UserManager<Users> _UserManager;
        private readonly IJWTGenerator _jWTGenerator;
        private readonly IUserAccessor _userAccessor;

        public GetCurrentUserQueryHandler(UserManager<Users> userManager, IJWTGenerator jWTGenerator, IUserAccessor userAccessor)
        {
            _UserManager = userManager;
            _jWTGenerator = jWTGenerator;
            _userAccessor = userAccessor;
        }
        public async Task<UserDTO> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _UserManager.FindByNameAsync(_userAccessor.GetCurrentUserName());
            return new UserDTO
            {
                DisplayName = user.UserName,
                FirstName = user.FirstName,
                LasrName = user.LastName,
                Token = _jWTGenerator.CreateToken(user)
            };
        }
    }
}
