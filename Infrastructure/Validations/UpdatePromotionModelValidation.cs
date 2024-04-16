using Core.Requests;
using Core.ViewModels;
using FluentValidation;

namespace Infrastructure.Validations
{
    public class UpdatePromotionModelValidation : AbstractValidator<UpdatePromotionModel>
    {
        public UpdatePromotionModelValidation()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null")
                .NotEmpty().WithMessage("Name cannot be empty")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters");

            RuleFor(x => x.DurationTimeInMinutes)
                .NotNull().WithMessage("DurationTime cannot be null");

            RuleFor(x => x.PercentageOff)
                .NotNull().WithMessage("PercentageOff cannot be null");
        }
    }
}
