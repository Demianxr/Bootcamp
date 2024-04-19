namespace Core.Requests
{
    public class CreateWithdrawalModel
    {
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }
    }
}

