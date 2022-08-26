//тут і нище описані специфікації які вказуть, які і як діставати дані з таблиць

using Ardalis.Specification;
using Core.Entities.CardEntity;

namespace Core.Specifications
{
    public static class CardSpecifications
    {
        internal class GetCardByUser : Specification<Card>
        {
            public GetCardByUser(string userId)
            {
                Query.Where(c => c.UserId == userId);
            }
        }

        internal class GetCardByNumber : Specification<Card>
            {
                public GetCardByNumber(string number)
                {
                    Query.Where(c => c.Number == number);
                }
            }
    }
}
