using Core.Interfaces.Repositories;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BankAPI.Repositories
{
    public class DepositRepository : IDepositRepository
    {
        private readonly BootcampContext _context;

        public DepositRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<Deposit> GetDepositAsync(string accountId)
        {
            return await _context.Deposits.FindAsync(accountId);
        }

        public async Task<IEnumerable<Deposit>> GetDepositsAsync(FilterDepositModel filterModel)
        {
            // Aquí puedes agregar la lógica para filtrar los depósitos según el modelo de filtro
            return await _context.Deposits.ToListAsync();
        }

        public async Task<Deposit> CreateDepositAsync(CreateDepositModel createModel)
        {
            var deposit = new Deposit(createModel.AccountId, createModel.BankId, createModel.Amount);
            _context.Deposits.Add(deposit);
            await _context.SaveChangesAsync();
            return deposit;
        }

        public async Task<Deposit> UpdateDepositAsync(string accountId, UpdateDepositModel updateModel)
        {
            var deposit = await _context.Deposits.FindAsync(accountId);
            if (deposit == null)
            {
                throw new KeyNotFoundException("Deposit not found");
            }

            deposit.Amount = updateModel.Amount;
            await _context.SaveChangesAsync();
            return deposit;
        }

        public async Task DeleteDepositAsync(string accountId)
        {
            var deposit = await _context.Deposits.FindAsync(accountId);
            if (deposit == null)
            {
                throw new KeyNotFoundException("Deposit not found");
            }

            _context.Deposits.Remove(deposit);
            await _context.SaveChangesAsync();
        }
    }
}
