//в цьому файлах і нище розміщується підключеня і налаштування памінгу моделей та ДТО

using AutoMapper;
using Core.DTO;
using Core.Entities.CardEntity;
using Core.Models;

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
