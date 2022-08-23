using Core.Entities.WalletEntity;
using Ardalis.Specification;

namespace Core.Specifications
{
    public static class WalletSpecification
    {
        internal class GetByUserId : Specification<Wallet>
            {
                public GetByUserId(string userId)
                {
                    Query.Where(w => w.UserId == userId);
                }
            }

        internal class GetById: Specification<Wallet>, ISingleResultSpecification<Wallet>
        {
            public GetById(int id)
            {
                Query.Where(w => w.Id == id)
                    .Include(w => w.Cash)
                    .ThenInclude(c => c.TypeMoney);
            }  
        }
    }
}
