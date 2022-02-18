using MediatR;
using ResidenceManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.ResidenceInvoices.AddResidenceInvoice
{
    public class AddResidenceInvoiceCommand : IRequest<BaseResponse>
    {
        public int InvoiceId { get; set; }
        public int UserResidenceId { get; set; }
        //public bool IsPaid { get; set; }
    }
}
