using AutoMapper;
using Core.Entities.CashEntity;
using Core.Entities.WalletEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Modals;
using Core.Resources;
using Core.Specifications;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CashService : ICashService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Cash> _cashRepository;
        private readonly IRepository<Wallet> _walletRepository;

        public CashService(
            IMapper mapper,
            IRepository<Cash> cashRepository,
            IRepository<Wallet> walletRepository)
        {
            _mapper = mapper;
            _cashRepository = cashRepository;
            _walletRepository = walletRepository;
        }

        public async Task AddCashAsync(CashModal cash)
        {
            var newWallet = await _walletRepository.GetByIdAsync(cash.WalletId);

            if (newWallet == null)
            {
                throw new HttpException(ErrorMessages.WalletNotFound, HttpStatusCode.NotFound);
            }

            var oldCash = await _cashRepository.GetBySpecAsync(
                new CashSpecification.GetCashByWalletTypeMoney(cash.WalletId, cash.TypeMoneyId));

            if (oldCash != null)
            {
                oldCash.Count += cash.Count;
                _cashRepository.UpdateAsync(oldCash);
            }
            else
            {
                await _cashRepository.AddAsync(_mapper.Map<Cash>(cash));
            }
        }

        public async Task RemainderCashAsync(double remainder, string typeMoney)
        {
            var cash = await _cashRepository
                .GetBySpecAsync(new CashSpecification.GetCashByTypeMoney(typeMoney));

            if (cash == null)
            {
                throw new HttpException(ErrorMessages.CashNotFound, HttpStatusCode.NotFound);
            }

            cash.Count = remainder;

            await _cashRepository.UpdateAsync(cash);
        }
    }
}
