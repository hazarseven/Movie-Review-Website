using FluentValidation;
using Movie_Core.DTO_s.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.FluentValidators.UserValidators
{
    public class EditUserValidator : AbstractValidator<EditUserDTO>
    {
        public EditUserValidator()
        {

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("The e-mail field cannot be left blank!")
                .EmailAddress()
                .WithMessage("Login in e-mail format!");


        }
    }
}
