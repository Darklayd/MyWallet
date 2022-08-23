using Ardalis.Specification;
using Core.Entities.TypesMoney;

namespace Core.Specifications
{
    public static class TypeMoneySpecification
    {
        internal class GetList : Specification<TypeMoney>
            {
                public GetList()
                {
                    Query.Where(t => t.Id > 0);
                }
            }
    }
}
