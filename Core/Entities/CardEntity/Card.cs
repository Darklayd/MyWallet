using Core.Entities.BankEntity;
using Core.Entities.WalletEntity;
using System;

namespace Core.Entities.CardEntity
{
    public class Card
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime CardTerm { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }
        public int CVC2 { get; set; }
        public Wallet Wallet { get; set; }
        public Bank Bank { get; set; }
    }
}
