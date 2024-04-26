using Core.Constants;

namespace Core.Entities;

public class Transfer
{
    public int Id { get; set; }
    public int OriginAccountId { get; set; }
    public int DestinationAccountId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransferDate { get; set; }

    public Transfer(int originAccountId, int destinationAccountId, decimal amount)
    {
        OriginAccountId = originAccountId;
        DestinationAccountId = destinationAccountId;
        Amount = amount;
        TransferDate = DateTime.Now;
    }

    //public bool ValidateTransfer(Account originAccount, Account destinationAccount)
    //{
    //    // d.1) Tiene que ser el mismo tipo de cuenta.
    //    if (originAccount.AccountType != destinationAccount.AccountType)
    //    {
    //        return false;
    //    }

    //    // d.2) Debe ser la misma moneda.
    //    if (originAccount.Currency != destinationAccount.Currency)
    //    {
    //        return false;
    //    }

    //    // d.3) El monto de transferencia no debe ser superior al saldo actual de la cuenta.
    //    if (originAccount.Balance < Amount)
    //    {
    //        return false;
    //    }

        //// d.4) La cuenta de origen debe estar activa.
        //if (!originAccount.IsActive)
        //{
        //    return false;
        //}

        //// d.5) Verificar Si la operación sobrepasa el límite operacional
        //if (Amount > originAccount.OperationalLimit)
        //{
        //    return false;
        //}

        //return true;
    }

//    public void ExecuteTransfer(Account originAccount, Account destinationAccount)
//    {
//        if (ValidateTransfer(originAccount, destinationAccount))
//        {
//            originAccount.Balance -= Amount;
//            destinationAccount.Balance += Amount;
//        }
//        else
//        {
//            throw new Exception("Transfer validation failed.");
//        }
//    }
//}


