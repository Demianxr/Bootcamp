using Core.Requests;
using FluentValidation;

namespace Infrastructure.Validations
{
    public class CreateUserRequestModelValidation : AbstractValidator<CreateUserRequestModel>
    {
        public CreateUserRequestModelValidation()
        {
            RuleFor(model => model.ProductType).NotEmpty().MaximumLength(50);
            RuleFor(model => model.Amount).GreaterThan(0);
            RuleFor(model => model.Currency).NotEmpty().Length(3);
            // Agrega cualquier otra regla de validación necesaria
        }
    }
}
