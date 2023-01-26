using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title field can not be empty");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Title can not be less than 8 characters");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Title can not be more than 20 characters");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description field can not be empty");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Title can not be less than 20 characters");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Title can not be more than 50 characters");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("ImageUrl field can not be empty");
           
        }
    }
}
