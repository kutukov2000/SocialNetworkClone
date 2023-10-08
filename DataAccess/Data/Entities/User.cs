namespace DataAccess.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string? AvatarImageUrl { get; set; }

        public List<Post>? Posts { get; set; }
    }
}
