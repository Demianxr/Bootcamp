namespace Core.Requests
{
    public class FilterDepositModel
    {
        public int? AccountId { get; set; }
        public int? BankId { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
