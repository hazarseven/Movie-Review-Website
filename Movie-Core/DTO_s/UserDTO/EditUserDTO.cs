using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.DTO_s.UserDTO
{
    public class EditUserDTO 
    {
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string? FirstName { get; set; }

        [Display(Name = "SurName")]
        public string? LastName { get; set; }

        [Display(Name = "Birth Date")]
        public string? BirthDate { get; set; }

        [Display(Name = "E-Mail")]
        public string? Email { get; set; }

        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Display(Name = "Password")]
        public string? Password { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
