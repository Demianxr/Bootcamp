using Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class FilterEnterpriseModel
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Formato de número de teléfono inválido")]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public EnterpriseStatus? Status { get; set; }
    }
}
