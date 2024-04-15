using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Request;
using Core.Requests;
using Infrastructure.Repositories;

namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<AccountDTO> Add(CreateAccountModel model)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDTO> Create(Core.Requests.CreateAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            return await _accountRepository.Delete(id);
        }

        public Task<AccountDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AccountDTO>> GetFiltered(FilterAccountModel filter)
        {
            return await _accountRepository.GetFiltered(filter);
        }

        public Task<AccountDTO> Update(UpdateAccountModel model)
        {
            throw new NotImplementedException();
        }
    }
}
      
