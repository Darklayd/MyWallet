using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO;
using Core.Models;

namespace Core.Interfaces.CustomService
{
    public interface IWalletService
        {
            Task CreateWalletAsync(WalletModel wallet);
            Task<List<WalletDTO>> GetWalletsAsync(string userId);
            Task<WalletInfoDTO> GetWalletByIdAsync(int walletId);
        }
}
