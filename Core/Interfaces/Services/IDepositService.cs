using Core.Models;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface IDepositService
    {
        Task<DepositDTO> GetDepositAsync(int accountId, int bankId);
        Task<IEnumerable<DepositDTO>> GetDepositsAsync(FilterDepositModel filter);
        Task<DepositDTO> CreateDepositAsync(CreateDepositModel createModel);
        Task<DepositDTO> UpdateDepositAsync(int accountId, int bankId, UpdateDepositModel updateModel);
        Task<bool> DeleteDepositAsync(int accountId, int bankId);
    }
}