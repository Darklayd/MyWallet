using Core.Entities.TypesMoney;
using Core.Entities.WalletEntity;

namespace Core.Entities.CashEntity
{
    public class Cash
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public TypeMoney TypeMoney { get; set; }
        public Wallet Wallet { get; set; }
    }
}
