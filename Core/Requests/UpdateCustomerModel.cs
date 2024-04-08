using Core.Constants;

namespace Core.Requests
{
    internal class UpdateCustomerModel
    { 
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; } 
        public CustomerStatus CustomerStatus { get; set; } = CustomerStatus.Active;
        public int BankId { get; set; }
        public DateTime? Birth {  get; set; }

    }
}
