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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Boş Geçilemez!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar Adı En Az 2 Karakter Olmalıdır!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar Adı En Fazla 50 Karakter Olmalıdır!");            
            //RuleFor(x => x.WriterName).Must(name => name != null && name.ToLower().Contains('a')).WithMessage("Yazar Adı İçerisinde En Az Bir 'a' Harfi Bulunmalıdır!");
        }
    }
}
