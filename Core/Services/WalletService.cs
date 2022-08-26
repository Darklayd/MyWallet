using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO;
using Core.Entities.UserEntity;
using Core.Entities.WalletEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Models;
using Core.Resources;
using Core.Specifications;

namespace Core.Services
{
    public class WalletService: IWalletService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Wallet> _walletRepository;
        private readonly IRepository<User> _userRepository;
        public WalletService
        (
            IMapper mapper,
            IRepository<Wallet> walletRepository,
            IRepository<User> userRepository
        )
        {
            _mapper = mapper;
            _walletRepository = walletRepository;
            _userRepository = userRepository;
        }

        public async Task CreateWalletAsync(WalletModel wallet)
        {
            var user = await _userRepository.GetByIdAsync(wallet.UserId);
            
            if (user == null)
            {
                throw new HttpException(ErrorMessages.UserNotFound, HttpStatusCode.NotFound);
            }

            var newWallet = _mapper.Map<Wallet>(wallet);
            newWallet.CreationDate = DateTime.UtcNow;

            await _walletRepository.AddAsync(newWallet);
        }

        public async Task<List<WalletDTO>> GetWalletsAsync(string userId)
        {
            var wallets = await _walletRepository
                .ListAsync(new WalletSpecification.GetByUserId(userId));
            return _mapper.Map<List<WalletDTO>>(wallets);
        }

        public async Task<WalletInfoDTO> GetWalletByIdAsync(int walletId)
        {
            var wallet = await _walletRepository
                .GetBySpecAsync(new WalletSpecification.GetById(walletId));
            return _mapper.Map<WalletInfoDTO>(wallet);
        }
    }
}
