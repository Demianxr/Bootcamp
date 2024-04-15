using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Repositories;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BusinessRepository : IBusinessRepository
    {
        private readonly BootcampContext _Context;

        public BusinessRepository(BootcampContext Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<Business>> GetAllBusinessesAsync()
        {
            return await _Context.Businesses.ToListAsync();
        }

        public async Task<IEnumerable<Business>> GetFilteredBusinessesAsync(string name, string address, string phone, string email)
        {
            var query = _Context.Businesses.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(b => b.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(address))
            {
                query = query.Where(b => b.Address.Contains(address));
            }

            if (!string.IsNullOrEmpty(phone))
            {
                query = query.Where(b => b.Phone.Contains(phone));
            }

            if (!string.IsNullOrEmpty(email))
            {
                query = query.Where(b => b.Email.Contains(email));
            }

            return await query.ToListAsync();
        }

    }
}
