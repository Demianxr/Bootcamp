using Core.Constants;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Requests;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MovementRepository : IMovementRepository
    {
        private readonly BootcampContext _context;

        public MovementRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movement>> GetMovementsAsync(FilterMovementModel filter)
        {
            var movements = _context.Movements.AsQueryable();

            if (filter.AccountId.HasValue)
            {
                movements = movements.Where(m => m.AccountId == filter.AccountId.Value);
            }

            return await movements.ToListAsync();
        }

        public async Task<Movement> GetMovementByIdAsync(int id)
        {
            
            return await _context.Movements.FindAsync(id);
        }

        public async Task CreateMovementAsync(CreateMovementModel movement)
        {
            
            var newMovement = new Movement
            {
                Destination = movement.Destination,
                Amount = movement.Amount,
                AccountId = movement.AccountId,
                TransferredDateTime = DateTime.Now,
                TransferStatus = TransferStatus.Pending
            };

            _context.Movements.Add(newMovement);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovementAsync(UpdateMovementModel movement)
        {
            
            var existingMovement = await _context.Movements.FindAsync(movement.Id);

            if (existingMovement != null)
            {
                existingMovement.Destination = movement.Destination;
                existingMovement.Amount = movement.Amount;
                existingMovement.AccountId = movement.AccountId;

                _context.Movements.Update(existingMovement);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteMovementAsync(int id)
        {
            
            var movement = await _context.Movements.FindAsync(id);

            if (movement != null)
            {
                _context.Movements.Remove(movement);
                await _context.SaveChangesAsync();
            }
        }
    }

}
