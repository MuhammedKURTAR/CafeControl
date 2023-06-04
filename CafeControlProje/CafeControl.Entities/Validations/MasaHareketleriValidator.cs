using CafeControl.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeControl.Entities.Validations
{
    public class MasaHareketleriValidator:AbstractValidator<MasaHareketleri>
    {
        public MasaHareketleriValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu Boş Bırakılamaz!");
            RuleFor(p => p.SatisKodu).Length(12).WithMessage("Satış Kodu 12 Karakterden Oluşmalı!");
            RuleFor(p => p.Miktari).NotEmpty().WithMessage("Miktar Boş Bırakılamaz!");
            RuleFor(p => p.Miktari).GreaterThan(0).WithMessage("Miktar 0 dan Küçük Olamaz.");
            
            RuleFor(p => p.BirimFiyati).NotEmpty().WithMessage("BirimFiyatı Boş Bırakılamaz!");
            RuleFor(p => p.BirimFiyati).LessThan(150).WithMessage("BirimFiyatı en fazla 150 Olabilir!");


        }
    }
}
