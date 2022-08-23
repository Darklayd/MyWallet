using Ardalis.Specification;
using Core.Entities.CashEntity;

namespace Core.Specifications
{
    public static class CashSpecification
    {
        internal class GetCashByWalletTypeMoney : Specification<Cash>, ISingleResultSpecification<Cash>
            {
                public GetCashByWalletTypeMoney(int walletId, int typeMoneyId)
                {
                    Query.Where(tm => 
                        tm.Wallet.Id == walletId && 
                        tm.TypeMoney.Id == typeMoneyId);
                }
            }

        internal class GetCashByTypeMoney : Specification<Cash>, ISingleResultSpecification<Cash>
            {
                public GetCashByTypeMoney(string typeMoney)
                {
                    Query.Where(tm => tm.TypeMoney.Name == typeMoney);
                }
            }
    }
}
