using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Requests;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BootcampContext _context;

        public TransactionRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<Transaction> GetTransactionByIdAsync(int id)
        {
            return await _context.Transactions.FindAsync(id);
        }

        public async Task<List<Transaction>> GetTransactionsAsync(FilterTransactionModel filter)
        {
            var query = _context.Transactions.AsQueryable();

            if (filter.AccountId.HasValue)
            {
                query = query.Where(t => t.AccountId == filter.AccountId.Value);
            }

            if (filter.FromDate.HasValue && filter.ToDate.HasValue)
            {
                query = query.Where(t => t.TransactionDate >= filter.FromDate.Value && t.TransactionDate <= filter.ToDate.Value);
            }
            else if (filter.FromDate.HasValue)
            {
                query = query.Where(t => t.TransactionDate >= filter.FromDate.Value);
            }
            else if (filter.ToDate.HasValue)
            {
                query = query.Where(t => t.TransactionDate <= filter.ToDate.Value);
            }


            return await query.ToListAsync();
        }

        public async Task CreateTransactionAsync(Transaction transaction)
        {
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTransactionAsync(Transaction transaction)
        {
        }

        public Task DeleteTransactionAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}