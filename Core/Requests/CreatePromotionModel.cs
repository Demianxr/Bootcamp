using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class CreatePromotionModel
    {
        public string Name { get; set; } = string.Empty;

        public DateTime? Start {  get; set; }

        public DateTime? End { get; set; }

        public int discount { get; set; }

        public List<int> RelatedEnterpiseIds { get; set; } = new List<int>();
    }
}
