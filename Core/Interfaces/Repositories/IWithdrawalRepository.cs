using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IWithdrawalRepository
    {
        Task<Withdrawal> GetWithdrawalByIdAsync(int id);
        Task<IEnumerable<Withdrawal>> GetWithdrawalsByAccountIdAsync(int accountId);
        Task AddWithdrawalAsync(Withdrawal withdrawal);
        Task UpdateWithdrawalAsync(Withdrawal withdrawal);
        Task DeleteWithdrawalAsync(int id);
    }
}
