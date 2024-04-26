using Core.Models;
using Core.Request;

namespace Core.Interfaces.Repositories;

public interface IRequestRepository
{
    Task<List<UserRequestDTO>> GetAll();
    Task<UserRequestDTO> Add(CreateRequestModel model);
    Task<bool> VerifyProductExists(int productId);
    Task<(bool customerExists, bool currencyExists)> VerifyCustomerAndCurrencyExist(int customerId, int currencyId);
}