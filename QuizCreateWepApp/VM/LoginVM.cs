using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCreateWepApp.VM
{

    public class LoginVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage ="Email field is required.")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password field is required.")]
        public string Password { get; set; }
    }
}
