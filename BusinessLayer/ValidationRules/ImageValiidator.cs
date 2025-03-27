using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Person Name cannot be empty");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Person Name cannot be empty");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu alanı boş geçilemez.");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Title must be at most 50 characters");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Title must be at most 50 characters");
            RuleFor(x => x.Description).MinimumLength(2).WithMessage("Title must be at least 2 characters");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Title must be at least 2 characters");

        }
    }
}
