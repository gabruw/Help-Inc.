using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class HelpIncContext : DbContext
    {
        public HelpIncContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
