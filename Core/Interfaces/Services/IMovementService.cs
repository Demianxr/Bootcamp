using Core.Models;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface IMovementService
    {
        Task<IEnumerable<MovementDTO>> GetMovementsAsync(FilterMovementModel filter);
        Task<MovementDTO> GetMovementByIdAsync(int id);
        Task CreateMovementAsync(CreateMovementModel movement);
        Task UpdateMovementAsync(UpdateMovementModel movement);
        Task DeleteMovementAsync(int id);
    }
}
