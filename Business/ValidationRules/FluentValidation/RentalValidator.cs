using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage("Araç ID'si boş olmamalıdır.");
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage("Müşteri ID'si boş olmamalıdır.");
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Kiralama tarihi boş olmamalıdır.");
        }
    }
}
