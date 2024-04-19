using Core.Entities;
using Core.Requests;

namespace Core.Interfaces.Repositories
{
    public interface IMovementRepository
    {
        Task<IEnumerable<Movement>> GetMovementsAsync(FilterMovementModel filter);
        Task<Movement> GetMovementByIdAsync(int id);
        Task CreateMovementAsync(CreateMovementModel movement);
        Task UpdateMovementAsync(UpdateMovementModel movement);
        Task DeleteMovementAsync(int id);
    }
}

