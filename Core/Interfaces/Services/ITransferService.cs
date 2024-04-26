using Core.Models;
using Core.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ITransferService
    {
        Task<TransferDTO> Add(CreateTransferModel model);
        Task<TransferDTO> GetById(int id);
        Task<TransferDTO> Update(UpdateTransferModel model);
        Task<bool> Delete(int id);
        Task<List<TransferDTO>> GetAll();
    }
}
