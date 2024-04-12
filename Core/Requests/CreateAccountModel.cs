namespace Core.Request
{
    public class CreateAccountModel
    {
        public string Holder { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public string Type { get; set; }

        public string AccountType { get; set; } =string.Empty;
        public string AccountStatus { get; set; } = string.Empty;

        public int CurrencyId { get; set; }

        public int CustomerId { get; set; }

    }
}