using MediatR;
using ResidenceManagement.Application.Models.Invoices;
using ResidenceManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.Invoices.AddInvoiceRange
{
    public class AddInvoiceRangeCommand : IRequest<BaseResponse>
    {
        public int Fee { get; set; }
        public int Year { get; set; }
    }
}
