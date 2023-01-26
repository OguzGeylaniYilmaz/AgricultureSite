using System.ComponentModel.DataAnnotations;

namespace AgricultureSite.App.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Please enter your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail")]   
        public string Mail { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        [Compare("Password",ErrorMessage ="Password do not match, please check it")]
        public string ConfirmPassword { get; set; }

    }
}
