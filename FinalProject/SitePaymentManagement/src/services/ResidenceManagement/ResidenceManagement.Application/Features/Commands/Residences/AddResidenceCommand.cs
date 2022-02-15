using MediatR;
using ResidenceManagement.Application.Models.Residences;
using ResidenceManagement.Domain.Entities.Managements;
using System.Collections.Generic;

namespace ResidenceManagement.Application.Features.Commands.Residences
{
    public class AddResidenceCommand : ResidenceAddVm, IRequest<Residence>
    {
    }
}