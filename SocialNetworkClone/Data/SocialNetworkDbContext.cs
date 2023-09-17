using Microsoft.EntityFrameworkCore;
using SocialNetworkClone.Data.Entities;

namespace SocialNetworkClone.Data
{
    public class SocialNetworkDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SocialNetworkDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    NickName = "user1",
                    FirstName = "Артур",
                    LastName = "Кутуков",
                    Email = "user1@example.com",
                    Password = "hashed_password1",
                    RegistrationDate = DateTime.Now,
                    BirthdayDate = DateTime.Parse("1990-01-01")
                },
                new User
                {
                    Id = 2,
                    NickName = "user2",
                    FirstName = "Дмитро",
                    LastName = "Довжаниця",
                    Email = "user2@example.com",
                    Password = "hashed_password2",
                    RegistrationDate = DateTime.Now,
                    BirthdayDate = DateTime.Parse("1995-05-15")
                },
                new User
                {
                    Id = 3,
                    NickName = "user3",
                    FirstName = "Микола",
                    LastName = "Панченко",
                    Email = "user3@example.com",
                    Password = "hashed_password3",
                    RegistrationDate = DateTime.Now,
                    BirthdayDate = DateTime.Parse("1985-03-10")
                },
                new User
                {
                    Id = 4,
                    NickName = "user4",
                    FirstName = "Дарина",
                    LastName = "Мищук",
                    Email = "user4@example.com",
                    Password = "hashed_password4",
                    RegistrationDate = DateTime.Now,
                    BirthdayDate = DateTime.Parse("1992-11-20")
                },
                new User
                {
                    Id = 5,
                    NickName = "user5",
                    FirstName = "Петро",
                    LastName = "Павлов",
                    Email = "user5@example.com",
                    Password = "hashed_password5",
                    RegistrationDate = DateTime.Now,
                    BirthdayDate = DateTime.Parse("1988-07-07")
                });

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 3,
                    UserId = 3,
                    TextContent = "Це пост користувача 3",
                    ImageLink = "https://images.unsplash.com/photo-1528717663417-3742fee05a29?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTR8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                },
                new Post
                {
                    Id = 4,
                    UserId = 4,
                    TextContent = "Це пост користувача 4",
                    ImageLink = "https://images.unsplash.com/photo-1487700160041-babef9c3cb55?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjB8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                },
                new Post
                {
                    Id = 5,
                    UserId = 5,
                    TextContent = "Це пост користувача 5",
                    ImageLink = "https://images.unsplash.com/photo-1619211142200-0d30ded30ca8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjN8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                },
                new Post
                {
                    Id = 6,
                    UserId = 5,
                    TextContent = "Це пост користувача 5",
                    ImageLink = "https://images.unsplash.com/photo-1531564701487-f238224b7ce3?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8cG9zdHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                },
                new Post
                {
                    Id = 8,
                    UserId = 3,
                    TextContent = "Це пост користувача 3",
                    ImageLink = "https://plus.unsplash.com/premium_photo-1669006982986-b87b59ff8b7c?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzF8fHBvc3R8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                },
                new Post
                {
                    Id = 7,
                    UserId = 5,
                    TextContent = "Це пост користувача 5",
                    ImageLink = "https://images.unsplash.com/photo-1518495973542-4542c06a5843?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8cG9zdHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
