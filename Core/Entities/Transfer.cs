using Core.Constants;

namespace Core.Entities
{
    public class Transfer
    {
        public int Id { get; set; }
        public int OriginAccountId { get; set; }
        public Account OriginAccount { get; set; }
        public int DestinationAccountId { get; set; }
        public Account DestinationAccount { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransferDate { get; set; }

        public Transfer(int originAccountId, int destinationAccountId, decimal amount)
        {
            OriginAccountId = originAccountId;
            DestinationAccountId = destinationAccountId;
            Amount = amount;
            TransferDate = DateTime.Now;
        }

        public bool ValidateTransfer()
        {
            
            if (OriginAccount.AccountType != DestinationAccount.AccountType)
            {
                throw new Exception("Las cuentas deben ser del mismo tipo.");
            }

            if (OriginAccount.CurrencyId != DestinationAccount.CurrencyId)
            {
                throw new Exception("Las cuentas deben ser de la misma moneda.");
            }

            if (Amount > OriginAccount.Balance)
            {
                throw new Exception("El monto de la transferencia no debe ser superior al saldo actual de la cuenta.");
            }

            if (OriginAccount.AccountStatus != AccountStatus.Active)
            {
                throw new Exception("La cuenta de origen debe estar activa.");
            }

            
            return true;
        }

        public void ExecuteTransfer()
        {
            if (ValidateTransfer())
            {
                OriginAccount.Withdraw(Amount);
                DestinationAccount.Deposit(Amount);
            }
        }
    }
}
    

