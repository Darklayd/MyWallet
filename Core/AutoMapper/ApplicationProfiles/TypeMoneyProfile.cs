using System.Runtime.InteropServices;
using AutoMapper;
using Core.DTO;
using Core.Entities.TypesMoney;

namespace Core.AutoMapper.ApplicationProfiles
{
    public class TypeMoneyProfile : Profile
    {
        public TypeMoneyProfile()
        {
            CreateMap<TypeMoney, TypeMoneyInfoDTO>();
        }
    }
}
