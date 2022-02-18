using AutoMapper;
using MediatR;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Exceptions;
using ResidenceManagement.Application.Models.Invoices;
using ResidenceManagement.Application.Responses;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.Invoices.UpdateInvoice
{
    public class UpdateInvoiceCommandHandler : IRequestHandler<UpdateInvoiceCommand, BaseDataResponse<Invoice>>
    {
        private readonly IMapper _mapper;
        private readonly IInvoiceRepository _invoiceRepository;
        public UpdateInvoiceCommandHandler(IMapper mapper, IInvoiceRepository invoiceRepository)
        {
            _mapper = mapper;
            _invoiceRepository = invoiceRepository;
        }

        public async Task<BaseDataResponse<Invoice>> Handle(UpdateInvoiceCommand request, CancellationToken cancellationToken)
        {
            var checkInvoice = await _invoiceRepository.GetByIdAsync(request.Id);
            if (checkInvoice == null)
                throw new NotFoundException(request);
            var response = _mapper.Map<Invoice>(request);
            await _invoiceRepository.UpdateAsync(response);
            return new BaseDataResponse<Invoice>(true, response);
        }
    }
}
