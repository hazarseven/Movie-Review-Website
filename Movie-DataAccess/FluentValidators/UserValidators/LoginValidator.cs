using FluentValidation;
using Movie_Core.DTO_s.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.FluentValidators.UserValidators
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("The username cannot be empty!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("The password cannot be empty!");
        }
    }
}
