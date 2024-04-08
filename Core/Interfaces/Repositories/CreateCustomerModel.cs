using Core.Constants;

namespace Core.Interfaces.Repositories
{
    public class CreateCustomerModel
    {
        public CustomerStatus customerStatus;

        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentNumer { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int BankId { get; set; }
        public DateTime? Bank { get; set; }
        public object Birth { get; set; }
    }
}