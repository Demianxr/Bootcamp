using Core.Entities;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface IUserRequestService
    {
        Task<UserRequest> GetUserRequestByIdAsync(int id);
        Task<IEnumerable<UserRequest>> GetAllUserRequestsAsync();
        Task<UserRequest> AddUserRequestAsync(CreateUserRequestModel model);
        Task<UserRequest> UpdateUserRequestAsync(UpdateUserRequestModel model);
        Task DeleteUserRequestAsync(int id);
    }
}
