using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.ViewModels
{
    public class RegisterViewModel
    {
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 20 characters")]
        public string Username { get; set; }

        [StringLength(60, MinimumLength = 10)]
        [EmailAddress(ErrorMessage = "Email must be between 10 and 60 characters")]
        public string Email { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password must be between 5 and 20 characters")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and ConfirmPassword mus be equal")]
        public string ConfirmPassword { get; set; }
    }
}
