namespace Core.Models
{
    public class BunisessDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; } = null;

        public PromotionDTO Promotion { get; set; } = null;
    }
}
