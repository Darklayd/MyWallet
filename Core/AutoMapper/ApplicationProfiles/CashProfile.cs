using AutoMapper;
using Core.DTO;
using Core.Entities.CashEntity;
using Core.Models;

namespace Core.AutoMapper.ApplicationProfiles
{
    public class CashProfile: Profile
    {
        public CashProfile()
        {
            CreateMap<Cash, CashModel>().ReverseMap();
            CreateMap<Cash, CashInfoDTO>()
                .ForMember(c => c.TypeMoney, tm => tm.MapFrom(c => c.TypeMoney));
        }
    }
}
