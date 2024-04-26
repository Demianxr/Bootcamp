using FluentValidation;
using Core.Requests;
using Core.Request;

namespace Infrastructure.Validations
{
    public class CreateDepositModelValidation : AbstractValidator<CreateDepositModel>
    {
        public CreateDepositModelValidation()
        {
            RuleFor(x => x.AccountId)
                .NotNull().WithMessage("AccountId cannot be null")
                .NotEmpty().WithMessage("AccountId cannot be empty");

            RuleFor(x => x.BankId)
                .NotNull().WithMessage("BankId cannot be null")
                .NotEmpty().WithMessage("BankId cannot be empty");

            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Amount must be greater than 0");
        }
    }
}
