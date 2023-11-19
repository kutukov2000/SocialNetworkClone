using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class SocialNetworkDbContext : IdentityDbContext<User>
    {
        public SocialNetworkDbContext() { }
        public SocialNetworkDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=tcp:kutukov-artur-azure-server.database.windows.net,1433;Initial Catalog=SocialNetworkClone-AzureDb;Persist Security Info=False;User ID=kutukov2000;Password=#4\"^%9c=F=.au_2\r\n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                        .HasOne(c => c.User)
                        .WithMany(u => u.Comments)
                        .HasForeignKey(c => c.AuthorUserId);

            modelBuilder.Entity<UserSubscription>()
                        .HasOne(us => us.Subscriber)
                        .WithMany(u => u.Subscribers)
                        .HasForeignKey(us => us.SubscriberId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserSubscription>()
                        .HasOne(us => us.SubscribedTo)
                        .WithMany(u => u.Subscriptions)
                        .HasForeignKey(us => us.SubscribedToId)
                        .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
    }
}
