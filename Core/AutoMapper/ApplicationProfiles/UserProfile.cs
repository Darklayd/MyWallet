using AutoMapper;
using Core.DTO;
using Core.Entities.UserEntity;
using Core.Models;

namespace Core.AutoMapper.ApplicationProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ProfileModel>();
            CreateMap<User, UserFullNameDTO>();
        }
    }
}
