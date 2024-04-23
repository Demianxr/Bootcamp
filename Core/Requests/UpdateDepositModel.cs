using System;
using System.ComponentModel.DataAnnotations;

    public class UpdateDepositModel
    {
        [Required]
        public string AccountId { get; set; }

        [Required]
        public string BankId { get; set; }

        [Required]
        [Range(0.01, 100000)] // Límite operacional
        public decimal Amount { get; set; }
    }

