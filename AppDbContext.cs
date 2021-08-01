using TweetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TweetApi
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        //public DbSet<Tweet> Tweets{ get; set; }
    }
}