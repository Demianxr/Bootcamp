namespace Core.Requests
{
    public class CreatePromotionModel
    {
        public string Name { get; set; } = string.Empty;
        public int? DurationTimeFrom { get; set; }
        public int? DurationTime { get; set; }
        public double? PercentageOff { get; set; }

    }
}
