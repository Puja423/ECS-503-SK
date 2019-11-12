using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment_II.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<FriendWith> FriendWith { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<PostImages> PostImages { get; set; }
        public DbSet<Reaction> Reaction { get; set; }
        public DbSet<ReactionType> ReactionTypes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Change this to comply with your database configuration
            options.UseSqlServer("Server=DESKTOP-G8LUJ2I;Database=SocialMedia;Trusted_Connection=True;");
        }
    }
}