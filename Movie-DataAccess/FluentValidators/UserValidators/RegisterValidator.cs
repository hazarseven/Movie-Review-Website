using FluentValidation;
using Movie_Core.DTO_s.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Movie_DataAccess.FluentValidators.UserValidators
{
    public class RegisterValidator : AbstractValidator<RegisterDTO>
    {

        public RegisterValidator()
        {
            Regex regex = new Regex("^[a-zA-Z- ığüşöçİĞÜŞÖÇ]*$");

            RuleFor(x => x.FirstName)
               .NotEmpty()
               .WithMessage("Ad alanı boş geçilemez!")
               .MaximumLength(100)
               .WithMessage("100 karakter sınırını geçemezsiniz!")
               .MinimumLength(3)
               .WithMessage("En az 3 karakter girmelisiniz!")
               .Matches(regex)
               .WithMessage("Sadece harf girebilirsiniz!");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Soyad alanı boş geçilemez!")
                .MaximumLength(200)
                .WithMessage("200 karakter sınırını geçemezsiniz!")
                .MinimumLength(2)
                .WithMessage("En az 2 karakter girmelisiniz!")
                .Matches(regex)
                .WithMessage("Sadece harf girebilirsiniz!");

            RuleFor(x => x.BirthDate)
                .NotEmpty()
                .WithMessage("Doğum tarihi zorunludur!");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("E-Mail alanı boş geçilemez!")
                .EmailAddress()
                .WithMessage("E-Mail formatında giriş yapınız!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Parola boş geçilemez!")
                .MinimumLength(1)
                .WithMessage("En az 1 karakter girmelisiniz!");

        }
    }
}