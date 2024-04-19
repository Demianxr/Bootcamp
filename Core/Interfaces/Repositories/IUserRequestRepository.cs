using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IUserRequestRepository
    {
        Task<UserRequest> GetByIdAsync(int id);
        Task<IEnumerable<UserRequest>> GetAllAsync();
        Task<UserRequest> AddAsync(UserRequest userRequest);
        Task<UserRequest> UpdateAsync(UserRequest userRequest);
        Task DeleteAsync(int id);
    }

}
