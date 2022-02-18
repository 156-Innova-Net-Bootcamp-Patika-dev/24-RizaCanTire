using AutoMapper;
using MediatR;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Exceptions;
using ResidenceManagement.Application.Responses;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.ResidenceInvoices.AddResidenceInvoiceRange
{
    public class AddRangeResidenceInvoiceCommandHandler : IRequestHandler<AddRangeResidenceInvoiceCommand, BaseResponse>
    {
        private readonly IResidenceInvoiceRepository _residenceInvoiceRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;
        private readonly IResidenceRepository _residenceRepository;
        private readonly IUserResidenceRepository _userResidenceRepository;

        public AddRangeResidenceInvoiceCommandHandler(IResidenceInvoiceRepository residenceInvoiceRepository, IInvoiceRepository invoiceRepository, IMapper mapper, IResidenceRepository residenceRepository, IUserResidenceRepository userResidenceRepository)
        {
            _residenceInvoiceRepository = residenceInvoiceRepository;
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
            _residenceRepository = residenceRepository;
            _userResidenceRepository = userResidenceRepository;
        }

        public async Task<BaseResponse> Handle(AddRangeResidenceInvoiceCommand request, CancellationToken cancellationToken)
        {

            var residenceInvoce = await _residenceInvoiceRepository.GetAllAsync(r => r.Invoice.Year == request.Year);
            if (residenceInvoce == null)
                throw new NotEmptyException("Toplu aidat girilemez. Aidat bilgisi ekli.");

            var invoiceList =await _invoiceRepository.GetAllAsync(p=>p.Year == request.Year);
            if (invoiceList == null)
                throw new NotFoundException(request);

            var residenceList = await _userResidenceRepository.GetAllAsync(p => p.Residence.IsFull);
            if (residenceList == null)
                throw new NotEmptyException("Boş daire yok.");
            
            foreach(var residence in residenceList)
            {
                foreach (var invoice in invoiceList)
                {
                    var addResidenceInvoice = new ResidenceInvoice();
                    addResidenceInvoice.UserResidenceId = residence.ResidenceId;
                    addResidenceInvoice.InvoiceId = invoice.Id;
                    await _residenceInvoiceRepository.AddAsync(addResidenceInvoice);
                }
                 
            }

            return new BaseResponse(true);

        }
    }
}
