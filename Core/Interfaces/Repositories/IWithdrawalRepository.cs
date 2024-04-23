public interface IWithdrawalRepository
{
    Task<Withdrawal> CreateAsync(Withdrawal withdrawal);
    Task<Withdrawal> UpdateAsync(Withdrawal withdrawal);
    Task DeleteAsync(int id);
    Task<Withdrawal> GetByIdAsync(int id);
    Task<IEnumerable<Withdrawal>> FilterAsync(FilterWithdrawalModel filterModel);
}
