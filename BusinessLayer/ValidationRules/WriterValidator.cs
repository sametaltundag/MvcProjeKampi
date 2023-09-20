using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş olamaz.").MinimumLength(3).WithMessage("Yazar adı en az 3 karakter olmalıdır.").MaximumLength(20).WithMessage("Yazar adı en fazla 20 karakter olmalıdır.");

            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Kategori açıklaması boş olamaz.").MinimumLength(2).WithMessage("Yazar adı en az 2 karakter olmalıdır.").MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkındası boş olamaz.").MinimumLength(10).WithMessage("Yazar hakkındası en az 10 karakter olmalıdır.").MaximumLength(250).WithMessage("Yazar hakkındası en fazla 250 karakter olmalıdır.");

            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar ünvanı boş geçilemez.").MinimumLength(3).WithMessage("E naz 3 karakter giriniz.").MaximumLength(50).WithMessage("En fazla 50 karakter yazılabilir.");
        }
    }
}
