using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Core.DTO_s.UserDTO
{
    public class LoginDTO
    {
        [Display(Name = "Kullanıcı Adı")]
        public string? UserName { get; set; }

        [Display(Name = "Parola")]
        public string? Password { get; set; }
    }
}
