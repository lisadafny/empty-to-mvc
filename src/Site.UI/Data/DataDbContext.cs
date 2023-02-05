using Microsoft.EntityFrameworkCore;

namespace Site.UI.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
                
        }
    }
}
