using Core.Constants;

namespace Core.Entities
{
    public class SavingAccount
    {
        public int Id { get; set; }

        public ESavingType SavingType { get; set; } = ESavingType.Insight;

        public string HolderName { get; set; } = string.Empty;

        public int AccountId { get; set; }
        public Account Account { get; set; } = null!;

        public Currency Currency { get; set; }

        public decimal DesiredAmount { get; set; }
        public int PreferredTerm { get; set; }
        public string Brand { get; set; } = string.Empty;
        public DateTime ApplicationDate { get; set; }
        public DateTime ApprovalDate { get; set; }
    }
}