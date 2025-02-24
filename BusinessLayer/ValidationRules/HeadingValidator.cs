using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Başlık Adı Boş Geçilemez!");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori Boş Geçilemez!");
            RuleFor(x => x.WriterId).NotEmpty().WithMessage("Yazar Boş Geçilemez!");
        }
    }
}
