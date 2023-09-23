using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model.Authentication.SignUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "User Name is requied")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is requied")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Password is requied")]
        public string? Password { get; set; }
    }
}
