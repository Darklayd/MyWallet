using AutoMapper;
using Core.DTO;
using Core.Entities.CardEntity;
using Core.Modals;

namespace Core.AutoMapper.ApplicationProfiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<Card, CardModel>().ReverseMap();
            CreateMap<Card, CardInfoDTO>();
        }
    }
}
