public class UpdateWithdrawalModel
{
    public int AccountId { get; set; }
    public int BankId { get; set; }
    public decimal Amount { get; set; }

    public UpdateWithdrawalModel(int accountId, int bankId, decimal amount)
    {
        AccountId = accountId;
        BankId = bankId;
        Amount = amount;
    }
}
