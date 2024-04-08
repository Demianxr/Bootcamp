using Core.Constants;

namespace WebApi.Controllers
{
    public class UpdateCustomerModel
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public CustomerStatus CustomerStatus { get; set; } = CustomerStatus.Active;
        public string BankId { get; set; }
        public DateTime? Birth { get; set; }

    }
}