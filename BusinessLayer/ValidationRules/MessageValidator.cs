using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail'i Boş Geçilemez!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Boş Geçilemez!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj Boş Geçilemez!");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Geçerli Bir Mail Adresi Giriniz!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu En Az 3 Karakter Olmalıdır!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu En Fazla 100 Karakter Olmalıdır!");
        }
    }
}
