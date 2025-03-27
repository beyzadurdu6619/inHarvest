using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Person Name cannot be empty");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Person Name cannot be empty");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu alanı boş geçilemez.");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Title must be at most 50 characters");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Title must be at most 50 characters");
            RuleFor(x => x.PersonName).MinimumLength(2).WithMessage("Title must be at least 2 characters");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Title must be at least 2 characters");      

        }
    }
}

