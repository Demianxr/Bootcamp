using Core.Requests;
using FluentValidation;

namespace Infrastructure.Validations
{
    public class CreateCustomerModelValidation : AbstractValidator<CreateCreditCardModel>
    {
        public CreateCustomerModelValidation()
        {
            RuleFor(x => x.Designation)
                .NotNull().WithMessage("Designation cannot be null")
                .NotEmpty().WithMessage("Designation cannot be empty")
                .MaximumLength(100).WithMessage("Designation cannot exceed 100 characters");

            RuleFor(x => x.IssueDate)
                .NotEmpty().WithMessage("Issue Date cannot be empty")
                .When(x => x.IssueDate != null); 

            RuleFor(x => x.ExpirationDate)
                .NotNull().WithMessage("Expiration Date cannot be null")
                .NotEmpty().WithMessage("Expiration Date cannot be empty");

            RuleFor(x => x.CardNumber)
                .NotNull().WithMessage("Card Number cannot be null")
                .NotEmpty().WithMessage("Card Number cannot be empty")
                .MinimumLength(16)
                .WithMessage("Card Number must have 16 characters");

            RuleFor(x => x.Designation)
                .NotNull().WithMessage("Designation cannot be null")
                .NotEmpty().WithMessage("Designation cannot be empty")
                .Length(1, 255).WithMessage("Designation must be between 1 and 255 characters");

            RuleFor(x => x.CurrencyId)
                .NotNull().WithMessage("CurrencyId cannot be null")
                .GreaterThan(0).WithMessage("CurrencyId must be a positive integer");


            RuleFor(x => x.CreditCardStatus)
                .MaximumLength(100).WithMessage("Credit Card Status cannot exceed 100 characters");

            RuleFor(x => x.CreditLimit)
                .NotNull().WithMessage("Credit Limit cannot be null");

            RuleFor(x => x.InterestRate)
                .NotNull().WithMessage("Interest Rate cannot be null");

            RuleFor(x => x.Availablecredit)
                .NotNull().WithMessage("Available Credit cannot be null");

            RuleFor(x => x.Currentdebt)
                .NotNull().WithMessage("Current Debt cannot be null");
        }
    }
}

