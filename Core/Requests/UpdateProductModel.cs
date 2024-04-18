using Core.Constants;

namespace Core.Requests
{
    public class UpdateProductModel
    {
        public int Id { get; set; } // Required for identifying the product to update
        public string Name { get; set; } // Optional for updating name
        public decimal Amount { get; set; } // Optional for updating amount
        public int Term { get; set; } // Optional for updating term (credits)
        public string Brand { get; set; } // Optional for updating brand (credit cards)
        public decimal InitialDeposit { get; set; } // Optional for updating initial deposit (current accounts)
    }
}
