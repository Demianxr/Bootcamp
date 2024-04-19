namespace Core.Requests
{
    public class FilterMovementModel
    {
        public int? AccountId { get; set; }
        public string? MonthYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
    }
}
