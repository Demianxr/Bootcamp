using Core.Models;
using Core.Request;
using Core.Requests;

namespace Core.Interfaces.Repositories
{
    public interface IAccountRepository
    {
        Task<List<AccountDTO>> GetFiltered(FilterAccountModel filter);
        Task<AccountDTO> Create(CreateAccountRequest request);
        Task<bool> Delete(int id);
        Task<AccountDTO> GetById(int id);
        Task<bool> CurrencyExists(int currencyId);
        Task<bool> CustomerExists(int customerId);
    }
}
