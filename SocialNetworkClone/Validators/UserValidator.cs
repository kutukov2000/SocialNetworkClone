using DataAccess.Data.Entities;
using FluentValidation;

namespace SocialNetworkClone.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.NickName)
                    .NotEmpty().WithMessage("Nickname is required.")
                    .Length(2, 30).WithMessage("Nickname must be between 2 and 30 characters.")
                    .Matches("^[a-zA-Z0-9._]*$").WithMessage("Nickname can only contain letters, numbers, periods, and underscores.");

            RuleFor(x => x.FirstName).NotNull().Length(5, 50);
            RuleFor(x => x.LastName).NotNull().Length(5, 50);
            RuleFor(x => x.BirthdayDate).NotNull();
        }
    }
}
