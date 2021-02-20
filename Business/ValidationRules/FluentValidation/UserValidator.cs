using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(u => u.FirstName).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalıdır.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Kullanıcı soyadı boş olamaz.");
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Kullanıcı soyadı en az 2 karakter olmalıdır.");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Email boş olamaz.");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre boş olamaz.");
        }
    }
}
