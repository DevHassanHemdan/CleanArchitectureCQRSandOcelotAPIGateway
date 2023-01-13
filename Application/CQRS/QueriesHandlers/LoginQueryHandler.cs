using Application.CQRS.Queries;
using Application.DTOs;
using Application.Interfaces;
using Application.IRepositories;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Rest;
using System.Net;

namespace Application.CQRS.QueriesHandlers
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, UserDTO>
    {
        private readonly UserManager<Users> _UserManager;
        private readonly SignInManager<Users> _SignInManager;
        private readonly IJWTGenerator _jWTGenerator;

        public LoginQueryHandler(UserManager<Users> userManager, SignInManager<Users> signInManager, IJWTGenerator jWTGenerator)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
            _jWTGenerator = jWTGenerator;
        }

        public async Task<UserDTO> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _UserManager.FindByEmailAsync("hassanhemdan92@gmail.com");

            if (user == null)
            {
                throw new RestException(HttpStatusCode.Unauthorized.ToString());
            }

            var result = await _SignInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                return new UserDTO
                {
                    DisplayName = user.UserName,
                    Token = _jWTGenerator.CreateToken(user),
                    Image = null
                };
            }

            throw new RestException(HttpStatusCode.Unauthorized.ToString());
        }
    }
}
