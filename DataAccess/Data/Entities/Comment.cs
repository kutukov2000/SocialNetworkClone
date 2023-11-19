namespace DataAccess.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public int PostId { get; set; }
        public required string AuthorUserId { get; set; }
        public Post? Post { get; set; }
        public User? User { get; set; }
    }
}
