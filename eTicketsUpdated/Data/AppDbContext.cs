using Microsoft.EntityFrameworkCore;

namespace eTicketsUpdated.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
    }
}
