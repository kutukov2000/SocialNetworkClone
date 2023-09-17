namespace SocialNetworkClone.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TextContent { get; set; }
        public string ImageLink { get; set; }
    }
}
