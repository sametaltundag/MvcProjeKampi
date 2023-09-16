using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior:AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş olamaz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori adı en fazla 20 karakter olmalıdır.");

            RuleFor(x=> x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş olamaz.");
            RuleFor(x => x.CategoryDescription).MinimumLength(10).WithMessage("Kategori adı en az 3 karakter olmalıdır.");
            RuleFor(x => x.CategoryDescription).MaximumLength(250).WithMessage("Kategori adı en fazla 50 karakter olmalıdır.");


        }
    }
}
