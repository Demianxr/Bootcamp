namespace Core.Requests
{
    public class UpdatePromotionModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TimeSpan? DurationTime { get; set; }

        public decimal? PercentageOff { get; set; }
    }
}
