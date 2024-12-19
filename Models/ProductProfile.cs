using AutoMapper;
using FMS.BusinessEntity;
using FMS.Common;
using FMS.Database;

namespace FMS.Models
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<UserRegistration, UserInfo>()
          .ForMember(dest => dest.PasswordSalt,
                     opt => opt.MapFrom(src => Helper.GeneratePassword(5)));
        }
    }
}
