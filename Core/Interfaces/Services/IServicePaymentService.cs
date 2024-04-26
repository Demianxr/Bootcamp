using Core.Models;
using Core.Request;

namespace Core.Interfaces.Services;

public interface IServicePaymentService
{
    Task<List<ServicePaymentDTO>> GetAll();
    Task<ServicePaymentDTO> Add(CreateServicePaymentModel model);
}