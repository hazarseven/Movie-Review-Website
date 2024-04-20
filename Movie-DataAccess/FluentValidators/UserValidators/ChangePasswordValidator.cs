using FluentValidation;
using Movie_Core.DTO_s.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.FluentValidators.UserValidators
{
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordDTO>
    {
        public ChangePasswordValidator()
        {
            RuleFor(x => x.OldPassword)
                .NotEmpty()
                .WithMessage("The Old Password cannot be empty!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("The New Password cannot be empty!");

            RuleFor(x => x.PasswordCheck)
                .NotEmpty()
                .WithMessage("The New Password repater cannot be empty!")
                .Equal(x => x.Password)
                .WithMessage("Passwords do not match!!");
        }
    }
}