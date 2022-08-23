using Core.Entities.WalletEntity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.UserEntity;

namespace Core.Entities.CardEntity
{
    public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime CardTerm { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }
        public string CVC2 { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
