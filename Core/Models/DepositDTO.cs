public class DepositDTO
{
    public string AccountId { get; set; }
    public string BankId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }

    public DepositDTO(string accountId, string bankId, decimal amount)
    {
        if (string.IsNullOrEmpty(accountId) || string.IsNullOrEmpty(bankId) || amount <= 0)
        {
            throw new ArgumentException("Invalid arguments");
        }

        AccountId = accountId;
        BankId = bankId;
        Amount = amount;
        TransactionDate = DateTime.Now;
    }
}

