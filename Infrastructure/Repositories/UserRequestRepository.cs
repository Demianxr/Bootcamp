using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRequestRepository : IUserRequestRepository
    {
        private readonly BootcampContext _context;

        public UserRequestRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<UserRequest> GetByIdAsync(int id)
        {
            return await _context.UserRequests.FindAsync(id);
        }

        public async Task<IEnumerable<UserRequest>> GetAllAsync()
        {
            return await _context.UserRequests.ToListAsync();
        }

        public async Task<UserRequest> AddAsync(UserRequest userRequest)
        {
            _context.UserRequests.Add(userRequest);
            await _context.SaveChangesAsync();
            return userRequest;
        }

        public async Task<UserRequest> UpdateAsync(UserRequest userRequest)
        {
            _context.Entry(userRequest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userRequest;
        }

        public async Task DeleteAsync(int id)
        {
            var userRequest = await _context.UserRequests.FindAsync(id);
            if (userRequest != null)
            {
                _context.UserRequests.Remove(userRequest);
                await _context.SaveChangesAsync();
            }
        }
    }

}
