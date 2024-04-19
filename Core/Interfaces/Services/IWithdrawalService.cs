using Core.Entities;
using Core.Models;

public interface IWithdrawalService
{
    Task<Withdrawal> GetWithdrawalByIdAsync(int id);
    Task<IEnumerable<Withdrawal>> GetWithdrawalsByAccountIdAsync(int accountId);
    Task AddWithdrawalAsync(WithdrawalDTO withdrawal);
    Task UpdateWithdrawalAsync(WithdrawalDTO withdrawal);
    Task DeleteWithdrawalAsync(int id);
}


