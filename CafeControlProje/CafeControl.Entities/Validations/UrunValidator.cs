using CafeControl.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeControl.Entities.Validations
{
    public class UrunValidator : AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.UrunKodu).NotEmpty().WithMessage("Ürün Kodu Boş Bırakılamaz!");
            RuleFor(p => p.UrunAdi).NotEmpty().WithMessage("Ürün Adı 12 Boş Bırakılamaz ");

            RuleFor(p => p.BirimFiyati1).NotEmpty().WithMessage("BirimFiyatı Boş Bırakılamaz!");
            RuleFor(p => p.BirimFiyati2).NotEmpty().WithMessage("BirimFiyatı2 Boş Bırakılamaz! ");
            RuleFor(p => p.BirimFiyati3).NotEmpty().WithMessage("BirimFiyatı3 Boş Bırakılamaz! ");

        }
    }
}
