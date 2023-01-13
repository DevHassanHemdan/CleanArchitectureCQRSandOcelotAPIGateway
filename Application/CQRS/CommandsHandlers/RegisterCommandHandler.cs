using Application.CQRS.Commands;
using Application.DTOs;
using Application.Interfaces;
using Application.IRepositories;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Rest;
using Presistance;
using System.Net;

namespace Application.CQRS.CommandsHandlers
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, UserDTO>
    {
        private readonly UserManager<Users> _UserManager;
        private readonly SignInManager<Users> _SignInManager;
        private readonly IJWTGenerator _jWTGenerator;
        private readonly DataContext _context;

        public RegisterCommandHandler(UserManager<Users> userManager, SignInManager<Users> signInManager, IJWTGenerator jWTGenerator, DataContext context)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
            _jWTGenerator = jWTGenerator;
            _context = context;
        }

        public async Task<UserDTO> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (await _context.Users.Where(x => x.Email == request.Email).AnyAsync())
                throw new RestException("Email is already exist");

            if (await _context.Users.Where(x => x.UserName == request.UserName).AnyAsync())
                throw new RestException("UserName is already exist");

            var user = new Users
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Address = request.Address
            };

            var result = await _UserManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                return new UserDTO
                {
                    FirstName = request.FirstName,
                    LasrName = request.LastName,
                    DisplayName = user.UserName,
                    Token = _jWTGenerator.CreateToken(user),
                };
            }
            throw new Exception("Error occured while saving");
        }
    }
}
