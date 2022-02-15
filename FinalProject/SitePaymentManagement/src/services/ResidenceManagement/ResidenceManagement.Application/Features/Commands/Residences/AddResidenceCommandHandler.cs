using AutoMapper;
using MediatR;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.Residences
{
    public class AddResidenceCommandHandler : IRequestHandler<AddResidenceCommand, Residence>
    {
        private IResidenceRepository _residenceRepository;
        private IMapper _mapper;

        public AddResidenceCommandHandler(IResidenceRepository residenceRepository, IMapper mapper)
        {
            _residenceRepository = residenceRepository;
            _mapper = mapper;
        }

        public async Task<Residence> Handle(AddResidenceCommand request, CancellationToken cancellationToken)
        {
            var res = await _residenceRepository.GetAllAsync();
            var entity = _mapper.Map<Residence>(res);
            
            return await _residenceRepository.AddAsync(entity);
        }
    }
}
