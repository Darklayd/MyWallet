using AutoMapper;
using Core.DTO;
using Core.Entities.UserEntity;
using Microsoft.AspNetCore.Identity;

namespace Core.AutoMapper.ApplicationProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ProfileDTO>();
            CreateMap<User, UserFullNameDTO>();
        }
    }
}
