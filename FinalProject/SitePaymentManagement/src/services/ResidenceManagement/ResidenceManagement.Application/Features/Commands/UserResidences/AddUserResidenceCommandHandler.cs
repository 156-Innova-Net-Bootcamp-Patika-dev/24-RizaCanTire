using AutoMapper;
using MediatR;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Models.UserResidences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Commands.UserResidences
{
    public class AddUserResidenceCommandHandler : IRequestHandler<AddUserResidenceCommand, UserResidenceAddVm>
    {
        private IUserResidenceRepository _userResidenceRepository;
        private IMapper _mapper;

        public AddUserResidenceCommandHandler(IUserResidenceRepository userResidenceRepository, IMapper mapper)
        {
            _userResidenceRepository = userResidenceRepository;
            _mapper = mapper;
        }

        public Task<UserResidenceAddVm> Handle(AddUserResidenceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
