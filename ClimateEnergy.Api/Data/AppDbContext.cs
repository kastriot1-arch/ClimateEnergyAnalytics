using Microsoft.EntityFrameworkCore;

namespace ClimateEnergy.Api.Data
{
    public class AppContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
