using Core.Entities.TypesMoney;
using Core.Entities.WalletEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.CashEntity
{
    public class Cash
    {
        public int Id { get; set; }
        public double Count { get; set; }
        [ForeignKey(nameof(TypeMoney))]
        public int TypeMoneyId { get; set; }
        public TypeMoney TypeMoney { get; set; }
        [ForeignKey(nameof(Wallet))]
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }
    }
}
