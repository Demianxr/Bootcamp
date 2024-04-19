using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Requests;

namespace Infrastructure.Services
{
    public class MovementService : IMovementService
    {
        private readonly IMovementRepository _movementRepository;

        public MovementService(IMovementRepository movementRepository)
        {
            _movementRepository = movementRepository;
        }

        public async Task<IEnumerable<MovementDTO>> GetMovementsAsync(FilterMovementModel filter)
        {
            var movements = await _movementRepository.GetMovementsAsync(filter);
            return movements.Select(m => new MovementDTO
            {
                Id = m.Id,
                Destination = m.Destination,
                Amount = m.Amount,
                TransferredDateTime = m.TransferredDateTime,
                TransferStatus = m.TransferStatus.ToString(),
                AccountId = m.AccountId
            });
        }

        public async Task<MovementDTO> GetMovementByIdAsync(int id)
        {
            var movement = await _movementRepository.GetMovementByIdAsync(id);
            return new MovementDTO
            {
                Id = movement.Id,
                Destination = movement.Destination,
                Amount = movement.Amount,
                TransferredDateTime = movement.TransferredDateTime,
                TransferStatus = movement.TransferStatus.ToString(),
                AccountId = movement.AccountId
            };
        }

        public async Task CreateMovementAsync(CreateMovementModel movement)
        {
            await _movementRepository.CreateMovementAsync(movement);
        }

        public async Task UpdateMovementAsync(UpdateMovementModel movement)
        {
            await _movementRepository.UpdateMovementAsync(movement);
        }

        public async Task DeleteMovementAsync(int id)
        {
            await _movementRepository.DeleteMovementAsync(id);
        }
    }

}
