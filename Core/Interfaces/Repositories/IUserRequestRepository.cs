using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IUserRequestRepository
    {
        Task<UserRequest> CreateAsync(UserRequest userRequest);
        Task<UserRequest> GetByIdAsync(int id);
        
    }
}
