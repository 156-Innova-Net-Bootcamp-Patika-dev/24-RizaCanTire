using MediatR;
using ResidenceManagement.Application.Models.PaymentControl;
using ResidenceManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.DuesController.AddDues
{
    public class AddDuesCommand :PaymentDto, IRequest<BaseResponse>
    {

    }
}
