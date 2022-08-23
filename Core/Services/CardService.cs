using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO;
using Core.Entities.CardEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Modals;
using Core.Resources;
using Core.Specifications;

namespace Core.Services
{
    public class CardService : ICardService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Card> _cardRepository;
        private readonly IRepository<User> _userRepository;
        public CardService(
            IMapper mapper, 
            IRepository<Card> cardRepository,
            IRepository<User> userRepository)
        {
            _mapper = mapper;
            _cardRepository = cardRepository;
            _userRepository = userRepository;
        }

        public async Task AddCardAsync(CardModel card)
        {
            var newCard = _mapper.Map<Card>(card);
            newCard.DateAdded = DateTime.UtcNow;

            await _cardRepository.AddAsync(newCard);
        }

        public async Task<List<CardInfoDTO>> GetCardsByUser(string userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
            {
                throw new HttpException(ErrorMessages.UserNotFound, HttpStatusCode.NotFound);
            }

            var cards = await _cardRepository.ListAsync(new CardSpecifications.GetCardByUser(userId));
            await _cardRepository.SaveChangesAsync();

            return _mapper.Map<List<CardInfoDTO>>(
                cards);
        }

        public async Task DeleteCardByNumber(string number)
        {
            var card = await _cardRepository
                .GetBySpecAsync(new CardSpecifications.GetCardByNumber(number));

            if (card == null)
            {
                throw new HttpException(ErrorMessages.CashNotFound, HttpStatusCode.NotFound);
            }

            _cardRepository.DeleteAsync(card);
        }
    }
}
