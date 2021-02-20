using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).GreaterThan(0).WithMessage("Aracın model yılı sıfırdan büyük olmalıdır.");
            RuleFor(c => c.Description).MinimumLength(6).WithMessage("Araç açıklaması 5 karakterden fazla olmalıdır.");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük fiyatı sıfırdan büyük olmalıdır.");
        }
    }
}
