using Microsoft.EntityFrameworkCore;
using Site.UI.Models;

namespace Site.UI.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
                
        }

        public DbSet<Client> Clients { get; set; }
    }
}
