using FluentValidation;
using ResidenceManagement.Application.Features.Commands.DuesControl.AddDues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.FluentValidations.DuesControl
{
    internal class AddDuesValidation : AbstractValidator<AddDuesCommand>
    {
        public AddDuesValidation()
        {
            RuleFor(r=>r.Fee).GreaterThan(10);
            RuleFor(r=>r.Year).GreaterThan(1900);
            RuleFor(r=>r.Month).LessThan(13).GreaterThan(0);
        }
    }
}
