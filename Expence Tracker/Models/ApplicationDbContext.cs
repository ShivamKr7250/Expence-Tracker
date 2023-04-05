using Microsoft.EntityFrameworkCore;

namespace Expence_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Categories{ get; set; }
    }
}
