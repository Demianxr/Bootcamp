namespace Infrastructure.Repositories
{
    public class CreateCustomersModel
    {
        public string Name { get; set; } = string.Empty;
        public string Lastname { get; set; } 
        public string DocumentNumber { get; set; } = string.Empty; 
        public string Address { get; set; } 
        public string Mail { get; set; } 
        public string Phone { get; set; } 
        public string CustomerSatatus { get; set; } = string.Empty; 
        public DateTime? Brith { get; set; }
        public int BankId { get; set; }
    }
}