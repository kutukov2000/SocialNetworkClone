namespace DataAccess.Data.Entities
{
    public class UserSubscription
    {
        public int Id { get; set; }

        public required string SubscriberId { get; set; }
        public User? Subscriber { get; set; }

        public required string SubscribedToId { get; set; }
        public User? SubscribedTo { get; set; }
    }
}
