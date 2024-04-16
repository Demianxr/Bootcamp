using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Core.Requests;
using Core.ViewModels;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class EnterpriseRepository : IEnterpriseRepository
    {
        private readonly BootcampContext _context;

        public EnterpriseRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Enterprise>> GetAllEnterprisesAsync()
        {
            return await _context.Enterprises.ToListAsync();
        }

        public async Task<IEnumerable<Enterprise>> GetFilteredEnterprisesAsync(string name, string address, string phone, string email)
        {
            var query = _context.Enterprises.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(address))
            {
                query = query.Where(e => e.Address.Contains(address));
            }

            if (!string.IsNullOrEmpty(phone))
            {
                query = query.Where(e => e.Phone == phone);
            }

            if (!string.IsNullOrEmpty(email))
            {
                query = query.Where(e => e.Email == email);
            }

            return await query.ToListAsync();
        }

        public async Task<Enterprise> GetEnterpriseByIdAsync(int id)
        {
            return await _context.Enterprises.FindAsync(id);
        }

        public async Task<Enterprise> CreateEnterpriseAsync(Enterprise enterprise)
        {
            if (enterprise == null)
            {
                throw new ArgumentNullException(nameof(enterprise));
            }

            await _context.Enterprises.AddAsync(enterprise);
            await _context.SaveChangesAsync();

            return enterprise;
        }

        public async Task<Enterprise> UpdateEnterpriseAsync(Enterprise enterprise)
        {
            if (enterprise == null)
            {
                throw new ArgumentNullException(nameof(enterprise));
            }

            _context.Entry(enterprise).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return enterprise;
        }

        public async Task DeleteEnterpriseAsync(int id)
        {
            var enterprise = await _context.Enterprises.FindAsync(id);
            if (enterprise != null)
            {
                _context.Enterprises.Remove(enterprise);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsEnterpriseAsync(int id)
        {
            return await _context.Enterprises.AnyAsync(e => e.Id == id);
        }

        public async Task<bool> ValidateEnterpriseEmailAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            return !await _context.Enterprises.AnyAsync(e => e.Email == email);
        }

        public Task<IEnumerable<Enterprise>> GetEnterprisesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Enterprise>> GetEnterprisesByFilterAsync(FilterEnterpriseModel filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<CurrencyDTO>> GetFiltered(FilterCurrencyModel filter)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO> Add(CreateCurrencyModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyDTO> Update(UpdateCurrencyModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CurrencyDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
