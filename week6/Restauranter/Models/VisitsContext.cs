using Microsoft.EntityFrameworkCore;

namespace Restauranter.Models
{
    public class VisitsContext : DbContext
    {
        public VisitsContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}