using Core.Models;
using Core.Request;
using Core.Requests;

namespace Core.Interfaces.Repositories;

public interface ICurrencyRepository
{
    Task<List<CurrencyDTO>> GetFiltered(FilterCurrencyModel filter);
    Task<BankDTO> Add(CreateBankModel model);
    Task<BankDTO> GetById(int id);
    Task<BankDTO> Update(UpdateBankModel model);
    Task<bool> Delete(int id);
    Task<List<CurrencyDTO>> GetAll();
}
