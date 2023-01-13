using Application.DTOs;
using Application.Validators;
using Domain;
using FluentValidation;
using MediatR;

namespace Application.CQRS.Commands
{
    public class RegisterCommand : IRequest<UserDTO>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class CommandValidator : AbstractValidator<RegisterCommand>
    {
        public CommandValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).ValidatePassword();
        }
    }
}
