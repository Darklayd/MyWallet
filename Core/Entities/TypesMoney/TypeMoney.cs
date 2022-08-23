using System.Collections.ObjectModel;
using System.Security.AccessControl;
using Core.Entities.CashEntity;

namespace Core.Entities.TypesMoney
{
    public class TypeMoney
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public Collection<Cash> Cash { get; set; }
    }
}
