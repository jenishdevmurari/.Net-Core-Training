using Validators;

using FluentValidation;

namespace Validators.Validators
{
    public class RegisterValidates : AbstractValidator<RegisterClass2>
    {
        public RegisterValidates()
        {

            RuleFor(x => x.Username).NotEmpty().WithMessage("Username is Required ");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required 3").EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
           
        }
    }
}
