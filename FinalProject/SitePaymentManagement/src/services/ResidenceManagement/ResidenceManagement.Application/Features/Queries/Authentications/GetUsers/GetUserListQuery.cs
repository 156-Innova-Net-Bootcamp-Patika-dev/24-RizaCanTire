using MediatR;
using ResidenceManagement.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Features.Queries.Authentications.GetUsers
{
    public class GetUserListQuery :IRequest<List<UserListModel>>
    {
    }
}
