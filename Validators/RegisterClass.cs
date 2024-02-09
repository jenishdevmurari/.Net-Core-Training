using System.ComponentModel.DataAnnotations;
using Validators.Validators;
using FluentValidation;

namespace Validators
{
    public class RegisterClass 
    {
        [Required]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required 1")]
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }


        [Compare("Email", ErrorMessage = "Your Email does not match!")]
        public string EmailConfirmed { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Your Password must containt 8 character")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Your Password does not match!")]
        public string PasswordConfirmed { get; set; }
   
    }
        

       
}
