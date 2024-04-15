using System;

namespace Core.Request
{
    public class FilterPromotionModel
    {
        public string Name { get; set; } = string.Empty;

        public TimeSpan? DurationTime { get; set; }

        public decimal? PercentageOff { get; set; }
    }
}
