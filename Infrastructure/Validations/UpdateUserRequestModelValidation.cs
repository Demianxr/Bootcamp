using Core.Requests;
using FluentValidation;

public class UpdateUserRequestModelValidation : AbstractValidator<UpdateUserRequestModel>
{
    public UpdateUserRequestModelValidation()
    {
        RuleFor(model => model.Id).NotEmpty().GreaterThan(0);
        RuleFor(model => model.ProductType).NotEmpty().MaximumLength(50);
        RuleFor(model => model.Amount).GreaterThan(0);
        RuleFor(model => model.Currency).NotEmpty().Length(3);
        
    }
}

