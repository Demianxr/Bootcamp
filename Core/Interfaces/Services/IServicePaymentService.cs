using Core.Entities;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface IServicePaymentService
    {
        Task<ServicePayment> GetServicePaymentByIdAsync(int id);
        Task<IEnumerable<ServicePayment>> GetAllServicePaymentsAsync();
        Task<ServicePayment> AddServicePaymentAsync(CreateServicePaymentModel model);
        Task<ServicePayment> UpdateServicePaymentAsync(UpdateServicePaymentModel model);
        Task DeleteServicePaymentAsync(int id);
    }
}
