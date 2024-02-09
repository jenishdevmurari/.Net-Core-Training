using System.ComponentModel.DataAnnotations;

namespace Validators
{
    public class RegisterClass1 : IValidatableObject
    {

        public string? Username { get; set; }
        public string Email { get; set; }
        public string EmailConfirmed { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmed { get; set; }



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Username))
            {
                errors.Add(new ValidationResult("Username is Required"));
                // yield return (new ValidationResult("Username is Required"));
            }



            if (string.IsNullOrEmpty(Email))
            {
                errors.Add(new ValidationResult("Email is Required 2"));
                // yield return (new ValidationResult("Password is Required"));

            }

            if (string.IsNullOrEmpty(EmailConfirmed))
            {
                errors.Add(new ValidationResult("Confirm Email is Required"));

            }

            if (string.IsNullOrEmpty(Password))
            {
                errors.Add(new ValidationResult("Password is Required"));


            }


            if (string.IsNullOrEmpty(PasswordConfirmed))
            {
                errors.Add(new ValidationResult("Confirm Password  is Required"));


            }

            if (Email != EmailConfirmed)
            {
                errors.Add(new ValidationResult("Your Email does not match!"));
            }

            if (Password != PasswordConfirmed)
            {
                errors.Add(new ValidationResult("Your Password does not match!"));
            }

            return errors;
        }
    }
    
}
