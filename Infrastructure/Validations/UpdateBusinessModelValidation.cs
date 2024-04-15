using Core.Requests;
using FluentValidation;

namespace Infrastructure.Validations
{
    public class UpdateBusinessModelValidation : AbstractValidator<UpdateBusinessModel>
    {
        public UpdateBusinessModelValidation()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null")
                .NotEmpty().WithMessage("Name cannot be empty")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters");

            RuleFor(x => x.Address)
                .MaximumLength(100).WithMessage("Address cannot exceed 100 characters");

            RuleFor(x => x.Phone)
                .MaximumLength(100).WithMessage("Phone cannot exceed 100 characters");

            RuleFor(x => x.Email)
                .MaximumLength(100).WithMessage("Email cannot exceed 100 characters");
        }
    }
}
