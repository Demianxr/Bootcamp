public class CreateWithdrawalModel
{
    public int AccountId { get; set; }
    public int BankId { get; set; }
    public decimal Amount { get; set; }

    public CreateWithdrawalModel(int accountId, int bankId, decimal amount)
    {
        AccountId = accountId;
        BankId = bankId;
        Amount = amount;
    }
}
