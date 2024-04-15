using Core.Request;
using Core.Requests;
using FluentValidation;

namespace Infrastructure.Validations
{
    public class CreateAccountModelValidation : AbstractValidator<CreateAccountModel>
    {
        public CreateAccountModelValidation()
        {
            RuleFor(x => x.Holder)
                .NotNull().WithMessage("Holder cannot be null")
                .NotEmpty().WithMessage("Holder cannot be empty");

            RuleFor(x => x.Number)
                .NotNull().WithMessage("Number cannot be null")
                .NotEmpty().WithMessage("Number cannot be empty");

         
            RuleFor(x => x.CurrencyId)
                .GreaterThan(0).WithMessage("CurrencyId must be greater than 0");

            RuleFor(x => x.CustomerId)
                .GreaterThan(0).WithMessage("CustomerId must be greater than 0");

            
        }
    }
}
