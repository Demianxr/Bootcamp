
    public class FilterDepositModel
    {
        public string AccountId { get; set; }
        public string BankId { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

