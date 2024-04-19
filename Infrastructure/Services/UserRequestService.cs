using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Requests;

public class UserRequestService : IUserRequestService
{
    private readonly IUserRequestRepository _repository;

    public UserRequestService(IUserRequestRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserRequest> GetUserRequestByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<UserRequest>> GetAllUserRequestsAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<UserRequest> AddUserRequestAsync(CreateUserRequestModel model)
    {
        var userRequest = new UserRequest
        {
            ProductType = model.ProductType,
            Amount = model.Amount,
            Currency = model.Currency,
            RequestDate = DateTime.Now
        };

        return await _repository.AddAsync(userRequest);
    }

    public async Task<UserRequest> UpdateUserRequestAsync(UpdateUserRequestModel model)
    {
        var userRequest = await _repository.GetByIdAsync(model.Id);
        if (userRequest != null)
        {
            userRequest.ProductType = model.ProductType;
            userRequest.Amount = model.Amount;
            userRequest.Currency = model.Currency;

            return await _repository.UpdateAsync(userRequest);
        }

        return null;
    }

    public async Task DeleteUserRequestAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}



