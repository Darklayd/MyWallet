using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO;

namespace Core.Interfaces.CustomService
{
    public interface IWalletService
        {
            Task CreateWalletAsync(WalletModal wallet);
            Task<List<WalletDTO>> GetWalletsAsync(string userId);
            Task<WalletInfoDTO> GetWalletByIdAsync(int walletId);
        }
}
