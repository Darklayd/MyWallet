using AutoMapper;
using Core.DTO;
using Core.Entities.WalletEntity;
using Core.Models;

namespace Core.AutoMapper.ApplicationProfiles
{
    public class WalletProfile: Profile
    {
        public WalletProfile()
        {
            CreateMap<Wallet, WalletModel>().ReverseMap();
            CreateMap<Wallet, WalletDTO>().ReverseMap();
            CreateMap<Wallet, WalletInfoDTO>()
                .ForMember(w => w.Cash, c => c.MapFrom(w => w.Cash));
        }
    }
}
