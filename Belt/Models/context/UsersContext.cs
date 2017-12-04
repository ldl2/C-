using Microsoft.EntityFrameworkCore;

namespace Belt.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}