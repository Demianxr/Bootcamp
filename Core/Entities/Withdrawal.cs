public class Withdrawal
{
    public int AccountId { get; set; }
    public int BankId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }

    public Withdrawal(int accountId, int bankId, decimal amount)
    {
        AccountId = accountId;
        BankId = bankId;
        Amount = amount;
        TransactionDate = DateTime.Now;
    }

    public bool PerformWithdrawal(Account account)
    {
        if (account == null)
            throw new ArgumentNullException(nameof(account));

        // Validate that the account has sufficient balance
        if (account.Balance < Amount)
        {
            Console.WriteLine("Insufficient balance.");
            return false;
        }

        // Validate that the amount does not exceed the operational limit
        if (Amount > account.OperationalLimit)
        {
            Console.WriteLine("The withdrawal amount exceeds the operational limit.");
            return false;
        }

        // Correctly update the balance
        account.Balance -= Amount;

        Console.WriteLine("Withdrawal successful.");
        return true;
    }
}
