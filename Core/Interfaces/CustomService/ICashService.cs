using System.Threading.Tasks;
using Core.Modals;

namespace Core.Interfaces.CustomService
{
    public interface ICashService
        {
            Task AddCashAsync(CashModal cash);
            Task RemainderCashAsync(double remainder, string typeMoney, CashModal toCash);
        }
}
