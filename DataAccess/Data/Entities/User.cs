using Microsoft.AspNetCore.Identity;

namespace DataAccess.Data.Entities
{
    public class User : IdentityUser
    {
        public string? NickName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string? AvatarImageUrl { get; set; }

        public List<Post>? Posts { get; set; }
    }
}
