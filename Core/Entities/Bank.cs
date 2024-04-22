using Core.Models;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal OperationalLimit { get; set; } 

        public ICollection<Customer> Customers { get; set; } = new List<Customer>();

        public BankDTO ToBankDTO()
        {
            throw new NotImplementedException();
        }
    }
}
