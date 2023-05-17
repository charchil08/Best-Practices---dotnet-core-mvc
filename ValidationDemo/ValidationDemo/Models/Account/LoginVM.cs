using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models.Account
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email required")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password required")]
        [PasswordPropertyText]
        public string Password { get; set; } = null!;

        [Compare("Password", ErrorMessage = "Password and confirm password must match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
