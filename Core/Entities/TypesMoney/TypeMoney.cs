using System.Collections.ObjectModel;
using Core.Entities.CashEntity;

namespace Core.Entities.TypesMoney
{
    public class TypeMoney
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Collection<Cash> Cash { get; set; }
    }
}
