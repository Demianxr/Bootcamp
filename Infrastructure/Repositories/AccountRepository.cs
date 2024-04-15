using Core.Constants;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Requests;
using Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly BootcampContext _context;

    public AccountRepository(BootcampContext context)
    {
        _context = context;
    }

    public async Task<AccountDTO> Add(CreateAccountRequest model)
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
        var account = await _context.Accounts
            .Include(a => a.Currency)
            .Include(a => a.Customer)
            .Include(a => a.SavingAccount)
            .Include(a => a.CurrentAccount)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (account is null) throw new NotFoundException($"The account with id: {id} doest not exist");

        return account.Adapt<AccountDTO>();
    }

    public async Task<List<AccountDTO>> GetFiltered(string? number, string? type, int? currencyId, int? customerId)
    {
        var query = _context.Accounts.AsQueryable();

        if (!string.IsNullOrEmpty(number))
        {
            query = query.Where(a => a.Number.Contains(number));
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


    public async Task<AccountDTO> Create(CreateAccountRequest request)
    {
        /*A modo de ejemplo*/
        #region PRUEBA
        var currency = new Currency()
        {
            Name = "Dolares Americanos",
            BuyValue = 10,
            SellValue = 20,
        };
        _context.Currency.Add(currency);

        //throw new Exception("Algo malo pasó");
        #endregion

        var account = request.Adapt<Account>();

        if (account.Type == AccountType.Saving)
        {
            account.SavingAccount = request.CreateCurrentAccount.Adapt<SavingAccount>();
        }

        if (account.Type == AccountType.Current)
        {
            account.CurrentAccount = request.CreateCurrentAccount.Adapt<CurrentAccount>();
        }

        _context.Accounts.Add(account);

        await _context.SaveChangesAsync();

        var createdAccount = await _context.Accounts
            .Include(a => a.Currency)
            .Include(a => a.Customer)
            .Include(a => a.SavingAccount)
            .Include(a => a.CurrentAccount)
            .FirstOrDefaultAsync(a => a.Id == account.Id);

        return createdAccount.Adapt<AccountDTO>();
    }


    public async Task<AccountDTO> Add(CreateAccountModel model)
    {
        var accountToCreate = model.Adapt<Account>();

        _context.Add(accountToCreate);
        await _context.SaveChangesAsync();

        var accountDTO = accountToCreate.Adapt<AccountDTO>();

        return accountDTO;
    }

    public Task<AccountDTO> Create(Core.Requests.CreateAccountRequest request)
    {
        throw new NotImplementedException();
    }
}