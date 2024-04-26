using Core.Models;
using Core.Request;

namespace Core.Interfaces.Repositories;

public interface IServicePaymentRepository
{
    Task<List<ServicePaymentDTO>> GetAll();
    Task<ServicePaymentDTO> Add(CreateServicePaymentModel model);
    Task<bool> VerifyServiceExists(int productId);
    Task<bool> IsSufficientBalance(int sourceAccountId, decimal amount);
    Task<bool> DoesAccountExist(int accountId);

}