using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ServicePaymentRepository : IServicePaymentRepository
    {
        private readonly BootcampContext _context;

        public ServicePaymentRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<ServicePayment> GetByIdAsync(int id)
        {
            return await _context.ServicePayments.FindAsync(id);
        }

        public async Task<IEnumerable<ServicePayment>> GetAllAsync()
        {
            return await _context.ServicePayments.ToListAsync();
        }

        public async Task<ServicePayment> AddAsync(ServicePayment servicePayment)
        {
            _context.ServicePayments.Add(servicePayment);
            await _context.SaveChangesAsync();
            return servicePayment;
        }

        public async Task<ServicePayment> UpdateAsync(ServicePayment servicePayment)
        {
            _context.Entry(servicePayment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return servicePayment;
        }

        public async Task DeleteAsync(int id)
        {
            var servicePayment = await _context.ServicePayments.FindAsync(id);
            if (servicePayment != null)
            {
                _context.ServicePayments.Remove(servicePayment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
   
