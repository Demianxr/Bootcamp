using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IServicePaymentRepository
    {
        Task<ServicePayment> GetByIdAsync(int id);
        Task<IEnumerable<ServicePayment>> GetAllAsync();
        Task<ServicePayment> AddAsync(ServicePayment servicePayment);
        Task<ServicePayment> UpdateAsync(ServicePayment servicePayment);
        Task DeleteAsync(int id);
    }
}
