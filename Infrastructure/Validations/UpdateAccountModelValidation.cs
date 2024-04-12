using Core.Constants;
using Core.Interfaces.Repositories;
using Core.Requests;
using FluentValidation;

public class UpdateAccountModelValidation : AbstractValidator<UpdateAccountModel>
{
    private readonly IAccountRepository _accountRepository;

    public UpdateAccountModelValidation(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleFor(m => m.Number)
            .NotEmpty().WithMessage("Account number is required")
            .MaximumLength(20).WithMessage("Account number cannot exceed 20 characters");

        RuleFor(m => m.Type)
            .NotEmpty().WithMessage("Account type is required")
            .Must(accountType => Enum.TryParse(typeof(AccountType), accountType, out _)).WithMessage("Invalid account type");

        RuleFor(m => m.CurrencyId)
            .GreaterThan(0).WithMessage("Currency ID is required and must be greater than 0")
            .MustAsync(async (currencyId, cancellationToken) => await _accountRepository.CurrencyExists(currencyId))
            .WithMessage("Invalid currency ID");

        RuleFor(m => m.CustomerId)
            .GreaterThan(0).WithMessage("Customer ID is required and must be greater than 0")
            .MustAsync(async (customerId, cancellationToken) => await _accountRepository.CustomerExists(customerId))
            .WithMessage("Invalid customer ID");
    }
}

