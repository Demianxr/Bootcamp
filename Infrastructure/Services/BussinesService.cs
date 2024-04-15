using Core.Entities;
using Core.Interfaces;

namespace Core.Services
{
    public class BusinessService : IBusinessRepository
    {
        private readonly IBusinessRepository _businessRepository;

        public BusinessService(IBusinessRepository businessRepository)
        {
            _businessRepository = businessRepository;
        }

        public async Task<IEnumerable<Business>> GetAllBusinessesAsync()
        {
            return await _businessRepository.GetAllBusinessesAsync();
        }

        public async Task<IEnumerable<Business>> GetFilteredBusinessesAsync(string name, string address, string phone, string email)
        {
            return await _businessRepository.GetFilteredBusinessesAsync(name, address, phone, email);
        }

        
    }
}
