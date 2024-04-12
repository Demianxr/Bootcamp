using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Core.Requests;
using Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BootcampContext _context;

        public AccountRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<AccountDTO> Add(CreateAccountModel model)
        {
            var accountToCreate = model.Adapt<Account>();

            _context.Add(accountToCreate);
            await _context.SaveChangesAsync();

            var accountDTO = accountToCreate.Adapt<AccountDTO>();

            return accountDTO;
        }

        public Task<bool> CurrencyExists(int currencyId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CustomerExists(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            var account = await _context.Accounts.FindAsync(id);

            if (account is null) throw new Exception("Account not found");

            account.IsDeleted = true;

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<List<AccountDTO>> GetAll()
        {
            var accounts = await _context.Accounts.ToListAsync();
            var accountDTOs = accounts.Select(account => account.Adapt<AccountDTO>()).ToList();
            return accountDTOs;
        }

        public async Task<AccountDTO> GetById(int id)
        {
            var account = await _context.Accounts.FindAsync(id);

            if (account is null) throw new Exception("Account not found");

            var accountDTO = account.Adapt<AccountDTO>();

            return accountDTO;
        }

        public async Task<List<AccountDTO>> GetFiltered(string? number, string? type, int? currencyId, int? customerId)
        {
            var query = _context.Accounts.AsQueryable();

            if (!string.IsNullOrEmpty(number))
            {
                query = query.Where(a => a.Number.Contains(number));
            }

            if (!string.IsNullOrEmpty(type))
            {
                query = query.Where(a => a.Type == type);
            }

            if (currencyId.HasValue && currencyId > 0)
            {
                query = query.Where(a => a.CurrencyId == currencyId);
            }

            if (customerId.HasValue && customerId > 0)
            {
                query = query.Where(a => a.CustomerId == customerId);
            }

            var accounts = await query.Include(a => a.Currency).ToListAsync();

            var accountDTOs = accounts.Select(account => account.Adapt<AccountDTO>()).ToList();

            return accountDTOs;
        }

        public Task<List<AccountDTO>> GetFiltered(FilterAccountModel filter)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountDTO> Update(UpdateAccountModel model)
        {
            var account = await _context.Accounts.FindAsync(model.Id);

            if (account is null) throw new Exception("Account was not found");

            model.Adapt(account);

            _context.Accounts.Update(account);

            await _context.SaveChangesAsync();

            var accountDTO = account.Adapt<AccountDTO>();

            return accountDTO;
        }

        Task<List<CustomerDTO>> IAccountRepository.GetAll()
        {
            throw new NotImplementedException();
        }


    }
}