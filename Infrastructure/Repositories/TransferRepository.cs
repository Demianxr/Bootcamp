using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Requests;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly BootcampContext _context;

        public TransferRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<Transfer> GetTransferById(int id)
        {
            return await _context.Transfers.FindAsync(id);
        }

        public async Task CreateTransfer(Transfer transfer)
        {
            _context.Transfers.Add(transfer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTransfer(Transfer transfer)
        {
            _context.Transfers.Update(transfer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTransfer(int id)
        {
            var transfer = await _context.Transfers.FindAsync(id);
            if (transfer != null)
            {
                _context.Transfers.Remove(transfer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Transfer>> GetTransfers(FilterTransferModel filterModel)
        {
            var query = _context.Transfers.AsQueryable();

            // Aquí puedes agregar la lógica para filtrar las transferencias según el modelo de filtro

            return await query.ToListAsync();
        }
    }
}
