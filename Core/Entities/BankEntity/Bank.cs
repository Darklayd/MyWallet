using Core.Entities.CardEntity;
using System.Collections.ObjectModel;

namespace Core.Entities.BankEntity
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Collection<Card> Cards { get; set; }
    }
}
