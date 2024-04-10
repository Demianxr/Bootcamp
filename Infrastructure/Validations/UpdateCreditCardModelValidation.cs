using Core.Requests;
using FluentValidation;

namespace Infrastructure.Validations
{
    public class UpdateCreditCardMoldelValidation : AbstractValidator<UpdateCreditCardModel>
    {
        public UpdateCreditCardMoldelValidation()
        {
            RuleFor(x => x.CardNumber)
                .NotNull().WithMessage("Card number cannot be null")
                .NotEmpty().WithMessage("Card number cannot be empty");

            RuleFor(x => x.ExpirationDate)
                .NotNull().WithMessage("Expiration date cannot be null")
                .NotEmpty().WithMessage("Expiration date cannot be empty");

            RuleFor(x => x.CVV)
                .NotNull().WithMessage("CCV cannot be null")
                .NotEmpty().WithMessage("CCV cannot be empty");
        }
    }
}

