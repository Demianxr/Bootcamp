namespace Core.Interfaces.Services
{
    public interface IDepositService
    {
        Task<Deposit> GetDepositAsync(string accountId);
        Task<IEnumerable<Deposit>> GetDepositsAsync(FilterDepositModel filterModel);
        Task<Deposit> CreateDepositAsync(CreateDepositModel createModel);
        Task<Deposit> UpdateDepositAsync(string accountId, UpdateDepositModel updateModel);
        Task DeleteDepositAsync(string accountId);
    }
}
