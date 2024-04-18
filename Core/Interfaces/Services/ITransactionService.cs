using Core.Models;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface ITransactionService
    {
        Task<TransactionDTO> GetTransactionByIdAsync(int id);
        Task<List<TransactionDTO>> GetTransactionsAsync(FilterTransactionModel filter);
        Task<TransactionDTO> CreateTransactionAsync(CreateTransactionModel model);
        Task<TransactionDTO> UpdateTransactionAsync(UpdateTransactionModel model);
        Task DeleteTransactionAsync(int id);
    }
}