using Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class FilterPromotionModel
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public int? MinimumDurationInMinutes { get; set; }

        [Range(0, int.MaxValue)]
        public int? MaximumDurationInMinutes { get; set; }

        [Range(0, 100)]
        public decimal? MinimumPercentageOff { get; set; }

        [Range(0, 100)]
        public decimal? MaximumPercentageOff { get; set; }

        public EnterpriseStatus? EnterpriseStatus { get; set; }
    }
}
