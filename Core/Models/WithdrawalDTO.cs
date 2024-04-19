namespace Core.Models
{
    public class WithdrawalDTO
    {
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }
        public int Id { get; set; }
        public WithdrawalDTO(int accountId, int bankId, decimal amount)
        {
            AccountId = accountId;
            BankId = bankId;
            Amount = amount;
        }
    }
}
