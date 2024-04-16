using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class UpdateEnterpriseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
