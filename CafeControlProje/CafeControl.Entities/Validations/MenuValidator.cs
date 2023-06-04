using CafeControl.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeControl.Entities.Validations
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(p => p.MenuAdi).NotEmpty().WithMessage("Menü Adı Boş Bırakılamaz!");
            RuleFor(p => p.MenuAdi).MinimumLength(3).WithMessage("Menü Adı En Az 3 Karakterden Oluşmalıdır.");
            RuleFor(p => p.MenuAdi).MaximumLength(12).WithMessage("Menü Adı En Fazla 12 Karakterden Oluşmalıdır.");


        }
    }
}
