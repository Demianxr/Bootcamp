using Core.Entities;

namespace Core.Models
{
    public class PromotionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? DurationTime { get; set; }
        public Decimal? PercentageOff { get; set; }

        public BunisessDTO Bunisess { get; set; } = null;
    }
}
