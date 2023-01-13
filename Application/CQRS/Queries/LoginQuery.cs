using Application.DTOs;
using Domain;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Queries
{
    public class LoginQuery : IRequest<UserDTO>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class QueryValidator : AbstractValidator<UserDTO>
    {
        //public QueryValidator()
        //{
        //    RuleFor(x=>x.Email).NotEmpty();
        //    RuleFor(x=>x.Password).NotEmpty();
        //}
    }
}
