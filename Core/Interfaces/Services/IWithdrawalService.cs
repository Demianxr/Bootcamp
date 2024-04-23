public interface IWithdrawalService
{
    Task<Withdrawal> CreateWithdrawalAsync(CreateWithdrawalModel model);
    Task<Withdrawal> UpdateWithdrawalAsync(int id, UpdateWithdrawalModel model);
    Task DeleteWithdrawalAsync(int id);
    Task<Withdrawal> GetWithdrawalAsync(int id);
    Task<IEnumerable<Withdrawal>> FilterWithdrawalsAsync(FilterWithdrawalModel filterModel);
}
