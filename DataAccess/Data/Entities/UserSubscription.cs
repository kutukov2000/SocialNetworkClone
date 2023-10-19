namespace DataAccess.Data.Entities
{
    public class UserSubscription
    {
        public int Id { get; set; }

        public string SubscriberId { get; set; }
        public User Subscriber { get; set; }

        public string SubscribedToId { get; set; }
        public User SubscribedTo { get; set; }
    }
}
