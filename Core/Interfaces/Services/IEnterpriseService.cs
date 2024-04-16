using Core.Entities;
using Core.Models;
using Core.Requests;
using Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IEnterpriseService
    {
        Task<List<AccountDTO>> GetFiltered(FilterAccountModel filter);
        Task<AccountDTO> Add(CreateAccountModel model);
        Task<AccountDTO> Update(UpdateAccountModel model);
        Task<bool> Delete(int id);
        Task<AccountDTO> Create(CreateAccountRequest request);
        Task<AccountDTO> GetById(int id);
    }
}
