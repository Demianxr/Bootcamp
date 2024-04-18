using Core.Constants;

namespace Core.Requests
{
    public class CreateProductModel
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Term { get; set; } // For credits
        public string Brand { get; set; } // For credit cards
        public decimal InitialDeposit { get; set; } // For current accounts
        public string Currency { get; set; }
    }
}
