using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class UpdatePromotionModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public int DurationTimeInMinutes { get; set; } 

        [Range(0, 100)]
        public decimal PercentageOff { get; set; }

        [Required]
        public int EnterpriseId { get; set; }
    }
}
