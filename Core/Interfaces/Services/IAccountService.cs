using Core.Models;
using Core.Request;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface IAccountService
    {
        Task<List<AccountDTO>> GetFiltered(FilterAccountModel filter);
        Task<AccountDTO> Add(CreateAccountModel model);
        Task<AccountDTO> Update(UpdateAccountModel model);
        Task<bool> Delete(int id);
    }
}
