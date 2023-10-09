using DataAccess.Data.Entities;
using FluentValidation;

namespace SocialNetworkClone.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Id).NotNull();

            RuleFor(x => x.NickName)
                    .NotEmpty().WithMessage("Nickname is required.")
                    .Length(2, 30).WithMessage("Nickname must be between 2 and 30 characters.")
                    .Matches("^[a-zA-Z0-9._]*$").WithMessage("Nickname can only contain letters, numbers, periods, and underscores.");

            //RuleFor(p => p.Password).NotEmpty().WithMessage("Your password cannot be empty")
            //        .MinimumLength(8).WithMessage("Your password length must be at least 8.")
            //        .MaximumLength(30).WithMessage("Your password length must not exceed 30.")
            //        .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
            //        .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
            //        .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
            //        .Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");

            RuleFor(x => x.FirstName).NotNull().Length(5, 50);
            RuleFor(x => x.LastName).NotNull().Length(5, 50);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.BirthdayDate).NotNull();
        }
    }
}
