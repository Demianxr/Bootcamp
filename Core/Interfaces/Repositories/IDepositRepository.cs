using Core.Entities;
using Core.Requests;

namespace Core.Interfaces.Repositories
{
    public interface IDepositRepository
    {
        Task<Deposit> GetDepositAsync(int accountId, int bankId);
        Task<IEnumerable<Deposit>> GetDepositsAsync(FilterDepositModel filter);
        Task<Deposit> CreateDepositAsync(CreateDepositModel createModel);
        Task<Deposit> UpdateDepositAsync(int accountId, int bankId, UpdateDepositModel updateModel);
        Task<bool> DeleteDepositAsync(int accountId, int bankId);
    }
}
