public class FilterWithdrawalModel
{
    public int? AccountId { get; set; }
    public int? BankId { get; set; }
    public decimal? MinAmount { get; set; }
    public decimal? MaxAmount { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public FilterWithdrawalModel(int? accountId = null, int? bankId = null, decimal? minAmount = null, decimal? maxAmount = null, DateTime? startDate = null, DateTime? endDate = null)
    {
        AccountId = accountId;
        BankId = bankId;
        MinAmount = minAmount;
        MaxAmount = maxAmount;
        StartDate = startDate;
        EndDate = endDate;
    }
}
