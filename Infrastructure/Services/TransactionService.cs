using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Requests;
using MapsterMapper;

namespace Infrastructure.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper; // Assuming AutoMapper or similar for DTO mapping

        public TransactionService(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TransactionDTO> GetTransactionByIdAsync(int id)
        {
            var transaction = await _repository.GetTransactionByIdAsync(id);
            return _mapper.Map<TransactionDTO>(transaction);
        }

        public async Task<List<TransactionDTO>> GetTransactionsAsync(FilterTransactionModel filter)
        {
            var transactions = await _repository.GetTransactionsAsync(filter);
            return _mapper.Map<List<TransactionDTO>>(transactions);
        }

        public async Task<TransactionDTO> CreateTransactionAsync(CreateTransactionModel model)
        {
            var transaction = _mapper.Map<Transaction>(model);
            await _repository.CreateTransactionAsync(transaction);
            return _mapper.Map<TransactionDTO>(transaction); // Return created transaction DTO
        }

        public async Task<TransactionDTO> UpdateTransactionAsync(UpdateTransactionModel model)
        {
            var existingTransaction = await _repository.GetTransactionByIdAsync(model.Id);

            if (existingTransaction == null)
            {
                throw new Exception("Transaction not found");
            }

            _mapper.Map(model, existingTransaction); // Update existing transaction entity
            await _repository.UpdateTransactionAsync(existingTransaction);
            return _mapper.Map<TransactionDTO>(existingTransaction); // Return updated transaction DTO
        }

        public async Task DeleteTransactionAsync(int id)
        {
            await _repository.DeleteTransactionAsync(id);
        }
    }
}