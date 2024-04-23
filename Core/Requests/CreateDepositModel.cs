using System.ComponentModel.DataAnnotations;

    public class CreateDepositModel
    {
        [Required]
        public string AccountId { get; set; }

        [Required]
        public string BankId { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }

