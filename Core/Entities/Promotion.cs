using Core.Models;

namespace Core.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? DurationTime { get; set; }
        public Decimal? PercentageOff { get; set; }

        public int BunisessId { get; set; }
        public Business Business { get; set; } = null;

    }
}
