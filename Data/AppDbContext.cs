using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApiEF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<City> City { get; set; }
    }
}
