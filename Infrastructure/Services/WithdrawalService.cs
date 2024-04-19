using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;

namespace Infrastructure.Services
{
    public class WithdrawalService : IWithdrawalService
    {
        private readonly IWithdrawalRepository _repository;

        public WithdrawalService(IWithdrawalRepository repository)
        {
            _repository = repository;
        }

        public async Task<Withdrawal> GetWithdrawalByIdAsync(int id)
        {
            return await _repository.GetWithdrawalByIdAsync(id);
        }

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalsByAccountIdAsync(int accountId)
        {
            return await _repository.GetWithdrawalsByAccountIdAsync(accountId);
        }

        public async Task AddWithdrawalAsync(WithdrawalDTO withdrawal)
        {
            var newWithdrawal = new Withdrawal(withdrawal.AccountId, withdrawal.BankId, withdrawal.Amount);
            await _repository.AddWithdrawalAsync(newWithdrawal);
        }

        public async Task UpdateWithdrawalAsync(WithdrawalDTO withdrawal)
        {
            var existingWithdrawal = await _repository.GetWithdrawalByIdAsync(withdrawal.Id);
            if (existingWithdrawal != null)
            {
                existingWithdrawal.AccountId = withdrawal.AccountId;
                existingWithdrawal.BankId = withdrawal.BankId;
                existingWithdrawal.Amount = withdrawal.Amount;
                await _repository.UpdateWithdrawalAsync(existingWithdrawal);
            }
        }

        public async Task DeleteWithdrawalAsync(int id)
        {
            await _repository.DeleteWithdrawalAsync(id);
        }
    }

}
