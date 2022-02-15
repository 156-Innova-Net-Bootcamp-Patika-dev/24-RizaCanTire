using AutoMapper;
using ResidenceManagement.Application.Features.Commands.Authentications.SignUpUser;
using ResidenceManagement.Application.Features.Queries.Authentications.SignInUser;
using ResidenceManagement.Application.Models.Residences;
using ResidenceManagement.Application.Models.UserResidences;
using ResidenceManagement.Application.Models.Users;
using ResidenceManagement.Domain.Entities.Auths;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region User
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<SignUpUserCommand, User>().ReverseMap();
            CreateMap<SignInUserCommandQuery, User>().ReverseMap();
            #endregion


            #region Dto ve Tablo'daki verilerin property ismi farklı olanları eşleştirme
            CreateMap<ResidenceDto, Residence>().ReverseMap().ForMember(dest=>dest.ResidenceType,
                act=>act.MapFrom(src=>src.ResidenceType.Type));
           
            #endregion

            #region User Residence DTO
            CreateMap<UserResidenceDto, User>().ReverseMap();
            CreateMap<UserResidenceDto, UserResidence>().ReverseMap();
            CreateMap<UserResidenceDto, ResidentType>().ReverseMap();


            #endregion







        }
    }
}
