using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Core.Requests;
using Core.ViewModels;

namespace Core.Services
{
    public class BusinessService : IEnterpriseRepository
    {
        private readonly IEnterpriseRepository _businessRepository;

        public BusinessService(IEnterpriseRepository businessRepository)
        {
            _businessRepository = businessRepository;
        }

        public Task<CurrencyDTO> Add(CreateCurrencyModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Enterprise> CreateEnterpriseAsync(Enterprise enterprise)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEnterpriseAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsEnterpriseAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CurrencyDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Enterprise> GetEnterpriseByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Enterprise>> GetEnterprisesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Enterprise>> GetEnterprisesByFilterAsync(FilterEnterpriseModel filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<CurrencyDTO>> GetFiltered(FilterCurrencyModel filter)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO> Update(UpdateCurrencyModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Enterprise> UpdateEnterpriseAsync(Enterprise enterprise)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateEnterpriseEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
