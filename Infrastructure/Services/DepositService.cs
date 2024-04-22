using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Requests;

namespace Infrastructure.Services
{
    public class DepositService : IDepositService
    {
        private readonly IDepositRepository _repository;
        private const decimal OperationalLimit = 6000000m;

        public DepositService(IDepositRepository repository)
        {
            _repository = repository;
        }

        public async Task<DepositDTO?> GetDepositAsync(int accountId, int bankId)
        {
            var deposit = await _repository.GetDepositAsync(accountId, bankId);
            return deposit == null ? null : new DepositDTO(deposit);
        }

        public async Task<IEnumerable<DepositDTO>> GetDepositsAsync(FilterDepositModel filter)
        {
            var deposits = await _repository.GetDepositsAsync(filter);
            return deposits.Select(d => new DepositDTO(d));
        }

        public async Task<DepositDTO> CreateDepositAsync(CreateDepositModel createModel)
        {
            if (!createModel.IsValid(OperationalLimit))
            {
                return null;
            }

            var deposit = await _repository.CreateDepositAsync(createModel);
            return new DepositDTO(deposit);
        }

        public async Task<DepositDTO?> UpdateDepositAsync(int accountId, int bankId, UpdateDepositModel updateModel)
        {
            if (updateModel.Amount.HasValue && !updateModel.IsValid(OperationalLimit))
            {
                return null;
            }

            var deposit = await _repository.UpdateDepositAsync(accountId, bankId, updateModel);
            return deposit == null ? null : new DepositDTO(deposit);
        }

        public async Task<bool> DeleteDepositAsync(int accountId, int bankId)
        {
            return await _repository.DeleteDepositAsync(accountId, bankId);
        }
    }
}
