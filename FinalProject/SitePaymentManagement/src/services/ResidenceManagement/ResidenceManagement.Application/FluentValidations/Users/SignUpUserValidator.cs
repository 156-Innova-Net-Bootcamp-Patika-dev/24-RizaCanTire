using FluentValidation;
using ResidenceManagement.Application.Features.Commands.Authentications.SignUpUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.FluentValidations.Users
{
    public class SignUpUserValidator : AbstractValidator<SignUpUserCommand>
    {
        public SignUpUserValidator()
        {

            RuleFor(p => p.Email).NotEmpty().WithMessage("{Email Address} is required.");

            RuleFor(p => p.Password).NotEmpty().WithMessage("{Password} is required.");

        }
    }
}
