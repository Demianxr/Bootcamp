using Core.Entities;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface IUserRequestService
    {
        Task<UserRequest> CreateUserRequestAsync(CreateUserRequestModel requestModel);
        Task<UserRequest> GetRequestByIdAsync(int id);
        
    }
}
