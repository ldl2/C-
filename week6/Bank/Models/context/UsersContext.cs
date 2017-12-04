using Microsoft.EntityFrameworkCore;

namespace Bank.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}