using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class UserRequestRepository : IUserRequestRepository
    {
        private readonly BootcampContext _context;

        public UserRequestRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<UserRequest> CreateAsync(UserRequest userRequest)
        {
            _context.UserRequests.Add(userRequest);
            await _context.SaveChangesAsync();
            return userRequest;
        }

        public async Task<UserRequest> GetByIdAsync(int id)
        {
            return await _context.UserRequests.FindAsync(id);
        }

       
    }
}
