using MediatR;
using ResidenceManagement.Application.Models.Invoices;
using ResidenceManagement.Application.Responses;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.Invoices.AddInvoice
{
    public class AddInvoiceCommand :AddInvoiceDto, IRequest<BaseDataResponse<InvoiceDto>>
    {
     
    }
}
