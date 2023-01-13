using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public static class ValidatorExtension
    {
        public static IRuleBuilder<T, string> ValidatePassword<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var result = ruleBuilder
                .NotEmpty()
                .MinimumLength(6).WithMessage("Password must be at least 6 characters")
                .Matches("[A-Z]").WithMessage("Password must contain 1 upper letter case")
                .Matches("[a-z]").WithMessage("Password must contain 1 lower letter case")
                .Matches("[0-9]").WithMessage("Password must contain a number")
                .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain non alphanumric");
            return result;
        }
    }
}
