public class WithdrawalService : IWithdrawalService
{
    private readonly IWithdrawalRepository _withdrawalRepository;

    public WithdrawalService(IWithdrawalRepository withdrawalRepository)
    {
        _withdrawalRepository = withdrawalRepository;
    }

    public async Task<Withdrawal> CreateWithdrawalAsync(CreateWithdrawalModel model)
    {
        var withdrawal = new Withdrawal(model.AccountId, model.BankId, model.Amount);
        return await _withdrawalRepository.CreateAsync(withdrawal);
    }

    public async Task<Withdrawal> UpdateWithdrawalAsync(int id, UpdateWithdrawalModel model)
    {
        var withdrawal = await _withdrawalRepository.GetByIdAsync(id);
        if (withdrawal == null)
            throw new KeyNotFoundException("Withdrawal not found.");

        withdrawal.Amount = model.Amount;
        return await _withdrawalRepository.UpdateAsync(withdrawal);
    }

    public async Task DeleteWithdrawalAsync(int id)
    {
        await _withdrawalRepository.DeleteAsync(id);
    }

    public async Task<Withdrawal> GetWithdrawalAsync(int id)
    {
        return await _withdrawalRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Withdrawal>> FilterWithdrawalsAsync(FilterWithdrawalModel filterModel)
    {
        return await _withdrawalRepository.FilterAsync(filterModel);
    }
}
