using Core.Requests;
using FluentValidation;

namespace Infrastructure.Validations
{
    public class CreatePromotionModelValidation : AbstractValidator<CreatePromotionModel>
    {
        public CreatePromotionModelValidation()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null")
                .NotEmpty().WithMessage("Name cannot be empty")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters");

            RuleFor(x => x.DurationTime)
                .NotNull().WithMessage("DurationTime cannot be null");

            RuleFor(x => x.PercentageOff)
                .NotNull().WithMessage("PercentageOff cannot be null");
        }
    }
}
