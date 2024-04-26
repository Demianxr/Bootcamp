using Core.Entities;
using Core.Requests;

namespace Core.Interfaces.Repositories
{
    public interface ITransferRepository
    {
        Task<Transfer> GetTransferById(int id);
        Task CreateTransfer(Transfer transfer);
        Task UpdateTransfer(Transfer transfer);
        Task DeleteTransfer(int id);
        Task<IEnumerable<Transfer>> GetTransfers(FilterTransferModel filterModel);
    }
}
