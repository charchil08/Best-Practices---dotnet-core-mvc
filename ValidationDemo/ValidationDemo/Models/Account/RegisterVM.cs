using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email required")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password required")]
        [PasswordPropertyText]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; } = null!;

        [Compare("Password", ErrorMessage = "Password and confirm password must match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
