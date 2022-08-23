using AutoMapper;
using Core.DTO;
using Core.Entities.UserEntity;
using Core.Modals;

namespace Core.AutoMapper.ApplicationProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ProfileModal>();
            CreateMap<User, UserFullNameDTO>();
        }
    }
}
