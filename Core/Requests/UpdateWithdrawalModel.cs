namespace Core.Requests
{
    public class UpdateWithdrawalModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }
    }
}

