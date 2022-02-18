using AutoMapper;
using MediatR;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Exceptions;
using ResidenceManagement.Application.Models.PaymentControl;
using ResidenceManagement.Application.Responses;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.DuesController.AddDues
{
    public class AddDuesCommandHandler : PaymentDto, IRequestHandler<AddDuesCommand, BaseResponse>
    {
        private IDuesRepository _duesRepository;
        private readonly IMapper _mapper;

        public AddDuesCommandHandler(IDuesRepository duesRepository, IMapper mapper)
        {
            _duesRepository = duesRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(AddDuesCommand request, CancellationToken cancellationToken)
        {
            var newDues = _mapper.Map<Dues>(request);
            var result = await _duesRepository.AddAsync(newDues);
            if (result == null)
                throw new NotFoundException(request);

            return new BaseResponse(true);
        }
    }
}
