using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class StaffValidator : AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            RuleFor(x => x.ID).GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field can not be empty");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Name can not be less than 5 characters");
            RuleFor(x => x.Name).MaximumLength(40).WithMessage("Title can not be mote than 40 characters");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title field can not be empty");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Title can not be less than 5 characters");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Title can not be mote than 50 characters");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image field can not be empty");
        }
    }
}
