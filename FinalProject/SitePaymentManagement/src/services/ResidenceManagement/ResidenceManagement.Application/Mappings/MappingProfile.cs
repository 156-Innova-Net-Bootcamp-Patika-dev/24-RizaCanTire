using AutoMapper;
using ResidenceManagement.Application.Features.Commands.Authentications.SignUpUser;
using ResidenceManagement.Application.Features.Commands.Authentications.UpdateUser;
using ResidenceManagement.Application.Features.Commands.Residences.AddResidence;
using ResidenceManagement.Application.Features.Commands.Residences.AddResidenceRange;
using ResidenceManagement.Application.Features.Commands.Residences.UpdateResidence;
using ResidenceManagement.Application.Features.Queries.Authentications.SignInUser;
using ResidenceManagement.Application.Models.Residences;
using ResidenceManagement.Application.Models.UserResidences;
using ResidenceManagement.Application.Models.Users;
using ResidenceManagement.Domain.Entities.Auths;
using ResidenceManagement.Domain.Entities.Managements;


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
            CreateMap<User, UserListModel>().ReverseMap(); 
            CreateMap<User, UserUpdateDto>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();

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

            #region Residence

            CreateMap<Residence, AddResidenceCommand>().ReverseMap();
            CreateMap<Residence, ResidenceAddVm>().ReverseMap(); 
            CreateMap<Residence, AddResidenceRangeCommand>().ReverseMap();
            CreateMap<Residence, UpdateResidenceCommand>().ReverseMap();

            #endregion






        }
    }
}
