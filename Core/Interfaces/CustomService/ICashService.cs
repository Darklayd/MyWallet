using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.CustomService
{
    public interface ICashService
        {
            Task AddCashAsync(CashModel cash);
            Task RemainderCashAsync(double remainder, string typeMoney, CashModel toCash);
        }
}
