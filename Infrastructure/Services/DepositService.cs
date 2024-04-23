using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace BankAPI.Services
{
    public class DepositService : IDepositService
    {
        private readonly IDepositRepository _repository;
        private const decimal OperationalLimit = 100000m; // Límite operacional

        public DepositService(IDepositRepository repository)
        {
            _repository = repository;
        }

        public async Task<Deposit> GetDepositAsync(string accountId)
        {
            return await _repository.GetDepositAsync(accountId);
        }

        public async Task<IEnumerable<Deposit>> GetDepositsAsync(FilterDepositModel filterModel)
        {
            // Aquí puedes agregar la lógica para filtrar los depósitos según el modelo de filtro
            return await _repository.GetDepositsAsync(filterModel);
        }

        public async Task<Deposit> CreateDepositAsync(CreateDepositModel createModel)
        {
            if (createModel.Amount > OperationalLimit) // Límite operacional
            {
                throw new InvalidOperationException("Operational limit exceeded");
            }

            return await _repository.CreateDepositAsync(createModel);
        }

        public async Task<Deposit> UpdateDepositAsync(string accountId, UpdateDepositModel updateModel)
        {
            if (updateModel.Amount > OperationalLimit) // Límite operacional
            {
                throw new InvalidOperationException("Operational limit exceeded");
            }

            return await _repository.UpdateDepositAsync(accountId, updateModel);
        }

        public async Task DeleteDepositAsync(string accountId)
        {
            await _repository.DeleteDepositAsync(accountId);
        }
    }
}
