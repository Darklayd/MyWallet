using AutoMapper;
using Core.DTO;
using Core.Entities.TypesMoney;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public class TypeMoneyService : ITypeMoneyService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<TypeMoney> _typeMoneyRepository;

        public TypeMoneyService(
            IMapper mapper,
            IRepository<TypeMoney> typeMoneyRepository)
        {
            _mapper = mapper;
            _typeMoneyRepository = typeMoneyRepository;
        }

        public async Task<List<TypeMoneyInfoDTO>> GetListAsync()
        {
            var typeMoney = await _typeMoneyRepository.ListAsync(
                new TypeMoneySpecification.GetList());
            await _typeMoneyRepository.SaveChangesAsync();
            return _mapper.Map<List<TypeMoneyInfoDTO>>(typeMoney);
        }

        public async Task<TypeMoneyInfoDTO> GetByIdAsync(int typeMoneyId)
        {
            return _mapper.Map<TypeMoneyInfoDTO>(await _typeMoneyRepository.GetByIdAsync(typeMoneyId));
        }
    }
}
