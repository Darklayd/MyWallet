//Тут і нище описані інтерфейси в яких описаний функціонал сервісів до кожної сутності

using System.Collections.Generic;
using Core.DTO;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.CustomService
{
    public interface ICardService
    {
        Task AddCardAsync(CardModel card);
        Task<List<CardInfoDTO>> GetCardsByUser(string userId);
        Task DeleteCardByNumber(string number);
    }
}
