namespace Core.DTOs
{
    public class PromotionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationTimeInMinutes { get; set; }
        public decimal PercentageOff { get; set; }
        public int EnterpriseId { get; set; }
    }
}
