using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Requests;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class WithdrawalRepository : IWithdrawalRepository
    {
        private readonly BootcampContext _context;

        public WithdrawalRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<Withdrawal> GetWithdrawalByIdAsync(int id)
        {
            return await _context.Withdrawals.FindAsync(id);
        }

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalsByAccountIdAsync(int accountId)
        {
            return await _context.Withdrawals
                .Where(w => w.AccountId == accountId)
                .ToListAsync();
        }

        public async Task AddWithdrawalAsync(Withdrawal withdrawal)
        {
            _context.Withdrawals.Add(withdrawal);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateWithdrawalAsync(Withdrawal withdrawal)
        {
            _context.Entry(withdrawal).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteWithdrawalAsync(int id)
        {
            var withdrawal = await _context.Withdrawals.FindAsync(id);
            if (withdrawal != null)
            {
                _context.Withdrawals.Remove(withdrawal);
                await _context.SaveChangesAsync();
            }
        }
    }
}

