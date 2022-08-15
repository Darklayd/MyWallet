using System;
using System.Collections.ObjectModel;
using Core.Entities.CardEntity;
using Core.Entities.CashEntity;
using Core.Entities.UserEntity;

namespace Core.Entities.WalletEntity
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public User User { get; set; }
        public Collection<Card> Cards { get; set; }
        public Collection<Cash> Cash { get; set; }
    }
}
