using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Requests;

public class UserRequestService : IUserRequestService
{
    private readonly IUserRequestRepository _userRequestRepository;

    public UserRequestService(IUserRequestRepository userRequestRepository)
    {
        _userRequestRepository = userRequestRepository;
    }

    public async Task<UserRequest> CreateUserRequestAsync(CreateUserRequestModel requestModel)
    {
        
        var userRequest = new UserRequest
        {
            ProductType = requestModel.ProductType,
            Amount = requestModel.Amount,
            Currency = requestModel.Currency,
            RequestDate = DateTime.Now,
            ApprovalDate = DateTime.MinValue // Se establecerá más tarde cuando se apruebe la solicitud
        };

        return await _userRequestRepository.CreateAsync(userRequest);
    }

    public async Task<UserRequest> GetRequestByIdAsync(int id)
    {
        return await _userRequestRepository.GetByIdAsync(id);
    }

    // Implementa otros métodos de IUserRequestService según sea necesario
}


