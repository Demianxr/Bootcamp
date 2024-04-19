using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Requests;

namespace Infrastructure.Services
{
    public class ServicePaymentService : IServicePaymentService
    {
        private readonly IServicePaymentRepository _repository;

        public ServicePaymentService(IServicePaymentRepository repository)
        {
            _repository = repository;
        }

        public async Task<ServicePayment> GetServicePaymentByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ServicePayment>> GetAllServicePaymentsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ServicePayment> AddServicePaymentAsync(CreateServicePaymentModel model)
        {
            var servicePayment = new ServicePayment
            {
                DocumentNumber = model.DocumentNumber,
                Amount = model.Amount,
                Description = model.Description,
                DebitAccountId = model.DebitAccountId,
                PaymentDate = DateTime.Now
            };

            return await _repository.AddAsync(servicePayment);
        }

        public async Task<ServicePayment> UpdateServicePaymentAsync(UpdateServicePaymentModel model)
        {
            var servicePayment = await _repository.GetByIdAsync(model.Id);
            if (servicePayment != null)
            {
                servicePayment.DocumentNumber = model.DocumentNumber;
                servicePayment.Amount = model.Amount;
                servicePayment.Description = model.Description;
                servicePayment.DebitAccountId = model.DebitAccountId;

                return await _repository.UpdateAsync(servicePayment);
            }

            return null;
        }

        public async Task DeleteServicePaymentAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
