using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO;

namespace Core.Interfaces.CustomService
{
    public interface ITypeMoneyService
        {
            Task<List<TypeMoneyInfoDTO>> GetListAsync();
            Task<TypeMoneyInfoDTO> GetByIdAsync(int typeMoneyId);
        }
}
