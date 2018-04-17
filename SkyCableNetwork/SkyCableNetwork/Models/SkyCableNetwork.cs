using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkyCableNetwork.Models
{
    public class SkyCableNetwork
    {
    }
    public partial class result
    {
        public int success { get; set; }
        public string msg { get; set; }

    }
    public partial class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }

    public partial class RegistrationModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }


    public partial class ForgotPasswordModel
    {
        [Required]
        public string Email { get; set; }

    }

    public partial class ResetPasswordModel
    {
        [Required]
        public string Password { get; set; }

    }

}