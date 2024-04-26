using Core.Request;
using FluentValidation;

namespace Infrastructure.Validations;

public class CreateRequestModelValidation : AbstractValidator<CreateRequestModel>
{
    public CreateRequestModelValidation()
    {
        RuleFor(x => x.ProductId)
          .NotEmpty().WithMessage("Customer Id cannot be empty");

        RuleFor(x => x.CustomerId)
             .NotEmpty().WithMessage("Customer Id cannot be empty");

        RuleFor(x => x.CurrencyId)
             .NotEmpty().WithMessage("Currency Id cannot be empty");
    }
}