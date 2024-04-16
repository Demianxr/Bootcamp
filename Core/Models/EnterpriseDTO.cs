namespace Core.DTOs
{
    public class EnterpriseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; } // Assuming Enterprise status is represented as a string
    }
}
