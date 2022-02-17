using AutoMapper;
using MediatR;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Responses;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.UserResidences.UpateUserResidence
{
    public class UpdateUserResidenceCommandHandler : IRequestHandler<UpdateUserResidenceCommand, BaseDataResponse<UserResidence>>
    {
        private IUserResidenceRepository _userResidenceRepository;
        private readonly IMapper _mapper;

        public UpdateUserResidenceCommandHandler(IUserResidenceRepository userResidenceRepository, IMapper mapper)
        {
            _userResidenceRepository = userResidenceRepository;
            _mapper = mapper;
        }

        public Task<BaseDataResponse<UserResidence>> Handle(UpdateUserResidenceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
