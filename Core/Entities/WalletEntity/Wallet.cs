using Core.Entities.CashEntity;
using Core.Entities.UserEntity;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.WalletEntity
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }
        public Collection<Cash> Cash { get; set; }
    }
}
