using Core.Entities;
using Core.Models;
using Core.Request;
using Core.Requests;
using Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IEnterpriseRepository
    {
        Task<List<CurrencyDTO>> GetFiltered(FilterCurrencyModel filter);
        Task<CurrencyDTO> Add(CreateCurrencyModel model);
        Task<CurrencyDTO> GetById(int id);
        Task<CurrencyDTO> Update(UpdateCurrencyModel model);
        Task<bool> Delete(int id);
        Task<List<CurrencyDTO>> GetAll();
    }
}
