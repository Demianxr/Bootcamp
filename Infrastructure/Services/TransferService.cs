using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Request;
using Core.Requests;

namespace Core.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        public TransferService(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task<TransferDTO> Add(CreateTransferModel model)
        {
            var transfer = new Transfer(model.OriginAccountId, model.DestinationAccountId, model.Amount);

            await _transferRepository.CreateTransfer(transfer);

            return new TransferDTO
            {
                Id = transfer.Id,
                OriginAccountId = transfer.OriginAccountId,
                DestinationAccountId = transfer.DestinationAccountId,
                Amount = transfer.Amount,
                TransferDate = transfer.TransferDate
            };
        }

        public async Task<bool> Delete(int id)
        {
            await _transferRepository.DeleteTransfer(id);
            return true;
        }

        public async Task<List<TransferDTO>> GetAll()
        {
            var transfers = await _transferRepository.GetTransfers(new FilterTransferModel());
            var transferDTOs = new List<TransferDTO>();

            foreach (var transfer in transfers)
            {
                transferDTOs.Add(new TransferDTO
                {
                    Id = transfer.Id,
                    OriginAccountId = transfer.OriginAccountId,
                    DestinationAccountId = transfer.DestinationAccountId,
                    Amount = transfer.Amount,
                    TransferDate = transfer.TransferDate
                });
            }

            return transferDTOs;
        }

        public async Task<TransferDTO> GetById(int id)
        {
            var transfer = await _transferRepository.GetTransferById(id);

            return new TransferDTO
            {
                Id = transfer.Id,
                OriginAccountId = transfer.OriginAccountId,
                DestinationAccountId = transfer.DestinationAccountId,
                Amount = transfer.Amount,
                TransferDate = transfer.TransferDate
            };
        }

        public async Task<TransferDTO> Update(UpdateTransferModel model)
        {
            var transfer = await _transferRepository.GetTransferById(model.Id);

            if (model.OriginAccountId.HasValue)
            {
                transfer.OriginAccountId = model.OriginAccountId.Value;
            }

            if (model.DestinationAccountId.HasValue)
            {
                transfer.DestinationAccountId = model.DestinationAccountId.Value;
            }

            if (model.Amount.HasValue)
            {
                transfer.Amount = model.Amount.Value;
            }

            await _transferRepository.UpdateTransfer(transfer);

            return new TransferDTO
            {
                Id = transfer.Id,
                OriginAccountId = transfer.OriginAccountId,
                DestinationAccountId = transfer.DestinationAccountId,
                Amount = transfer.Amount,
                TransferDate = transfer.TransferDate
            };
        }
    }
}
