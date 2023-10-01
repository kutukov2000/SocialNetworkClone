using DataAccess.Data.Entities;
using FluentValidation;

namespace SocialNetworkClone.Validators
{
    public class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x => x.TextContent)
                .NotNull().WithMessage("Text content cannot be empty.")
                .Length(1, 1000).WithMessage("Text content must be between 1 and 1000 characters.");

            RuleFor(x => x.ImageLink)
                .NotNull().WithMessage("Image link cannot be empty.")
                .NotEmpty().WithMessage("Image link cannot be empty.")
                .Must(BeAValidUrl).WithMessage("Please enter a valid URL for the image link.");
        }

        private bool BeAValidUrl(string url)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                Uri uriResult;
                return Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            }
            return false;
        }
    }
}
