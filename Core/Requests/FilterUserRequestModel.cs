namespace Core.Requests
{
    public class FilterUserRequestModel
    {
        public int? AccountId { get; set; }
        public string MonthYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }

        public FilterUserRequestModel(int? accountId, string monthYear, DateTime? startDate, DateTime? endDate, string description)
        {
            this.AccountId = accountId;
            this.MonthYear = monthYear;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Description = description;
        }
    }
}
