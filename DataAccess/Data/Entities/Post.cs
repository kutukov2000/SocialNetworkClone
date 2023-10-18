namespace DataAccess.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string TextContent { get; set; }
        public string ImageLink { get; set; }

        public ICollection<Comment>? Comments { get; set; }
        public User? User { get; set; }
    }
}
