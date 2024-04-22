using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Requests;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class DepositRepository : IDepositRepository
    {
        private readonly BootcampContext _context;

        public DepositRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<Deposit?> GetDepositAsync(int accountId, int bankId)
        {
            return await _context.Deposits.FindAsync(accountId, bankId);
        }

        public async Task<IEnumerable<Deposit>> GetDepositsAsync(FilterDepositModel filter)
        {
            var query = _context.Deposits.AsQueryable();

            if (filter.AccountId.HasValue)
            {
                query = query.Where(d => d.AccountId == filter.AccountId.Value);
            }

            if (filter.BankId.HasValue)
            {
                query = query.Where(d => d.BankId == filter.BankId.Value);
            }

            if (filter.MinAmount.HasValue)
            {
                query = query.Where(d => d.Amount >= filter.MinAmount.Value);
            }

            if (filter.MaxAmount.HasValue)
            {
                query = query.Where(d => d.Amount <= filter.MaxAmount.Value);
            }

            if (filter.StartDate.HasValue)
            {
                query = query.Where(d => d.TransactionDate >= filter.StartDate.Value);
            }

            if (filter.EndDate.HasValue)
            {
                query = query.Where(d => d.TransactionDate <= filter.EndDate.Value);
            }

            return await query.ToListAsync();
        }

        public async Task<Deposit> CreateDepositAsync(CreateDepositModel createModel)
        {
            var deposit = new Deposit(createModel.AccountId, createModel.BankId, createModel.Amount);
            _context.Deposits.Add(deposit);
            await _context.SaveChangesAsync();
            return deposit;
        }

        public async Task<Deposit?> UpdateDepositAsync(int accountId, int bankId, UpdateDepositModel updateModel)
        {
            var deposit = await _context.Deposits.FindAsync(accountId, bankId);

            if (deposit == null)
            {
                return null;
            }

            if (updateModel.Amount.HasValue)
            {
                deposit.Amount = updateModel.Amount.Value;
            }

            await _context.SaveChangesAsync();
            return deposit;
        }

        public async Task<bool> DeleteDepositAsync(int accountId, int bankId)
        {
            var deposit = await _context.Deposits.FindAsync(accountId, bankId);

            if (deposit == null)
            {
                return false;
            }

            _context.Deposits.Remove(deposit);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
