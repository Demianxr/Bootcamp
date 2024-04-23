using Core.Exceptions;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Request;
using MapsterMapper;

namespace Infrastructure.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public AccountService(IAccountRepository accountRepository, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task<AccountDTO> Add(CreateAccountModel model)
    {
        bool customerDoesntExist = await _accountRepository.VerifyCustomerExists(model.CustomerId);
        if (customerDoesntExist)
        {
            throw new CustomerNotFoundException(model.CustomerId);
        }

        bool currencyDoesntExist = await _accountRepository.VerifyCurrencyExists(model.CurrencyId);
        if (currencyDoesntExist)
        {
            throw new CurrencyNotFoundException(model.CurrencyId);
        }

        return await _accountRepository.Add(model);
    }

    public async Task<bool> Delete(int id)
    {
        return await _accountRepository.Delete(id);
    }

    public async Task<List<AccountDTO>> GetFiltered(FilterAccountModel filter)
    {
        return await _accountRepository.GetFiltered(filter);
    }

    public async Task<AccountDTO> Update(UpdateAccountModel model)
    {
        return await _accountRepository.Update(model);
    }
}
public class CustomerNotFoundException : BusinessLogicException
{
    public CustomerNotFoundException(int customerId) : base($"Customer {customerId} does not exist")
    {
    }
}

public class CurrencyNotFoundException : BusinessLogicException
{
    public CurrencyNotFoundException(int currencyId) : base($"Currency {currencyId} does not exist")
    {
    }



}

