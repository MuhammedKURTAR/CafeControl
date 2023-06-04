using CafeControl.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeControl.Entities.Validations
{
    public class KullanicilarValidator:AbstractValidator<Kullanicilar>
    
    {
        public KullanicilarValidator()
        {

            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad Boş Bırakılamaz."); // bazı boş geçilemeyecek yerler.
            RuleFor(p => p.KullanıcıAdi).NotEmpty().WithMessage("Kullanıcı Adı Boş Bırakılamaz.");
            RuleFor(p => p.KullanıcıAdi).MinimumLength(5).WithMessage("Kullnıcı Adı 5 Karakterden Az Olmamalıdır.");
            RuleFor(p => p.KullanıcıAdi).MaximumLength(20).WithMessage("Kullnıcı Adı 20 Karakterden Fazla Olmamalıdır.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola Boş Bırakılamaz.");
            RuleFor(p => p.Parola).MinimumLength(2).WithMessage("Parola 2 Karakterden Az Olmamalıdır.");
            RuleFor(p => p.Parola).MaximumLength(12).WithMessage("Parola 12 Karakterden Fazla Olmamalıdır.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon Boş Bırakılamaz.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email Adresi Boş Bırakılamaz.");
           
            RuleFor(p => p.Email).EmailAddress().WithMessage("Yanlış Email Adres Formatı!");

        }
    }
}
