namespace Core.Requests
{
    public class FilterWithdrawalModel
    {
        public int? AccountId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}

