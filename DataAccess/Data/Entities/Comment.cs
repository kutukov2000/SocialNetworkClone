﻿namespace DataAccess.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
        public string AuthorUserId { get; set; }
        public Post? Post { get; set; }
        public User? User { get; set; }
    }
}
