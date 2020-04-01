using Microsoft.EntityFrameworkCore;
using Domain.Entity;

namespace Repository.Context
{
    public class HelpIncContext : DbContext
    {
        public HelpIncContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Actor>();
            modelBuilder.Ignore<Address>();
            modelBuilder.Ignore<Default>();
            modelBuilder.Ignore<Geolocalization>();
            modelBuilder.Ignore<Group>();
            modelBuilder.Ignore<LoginUser>();
            modelBuilder.Ignore<Officer>();
            modelBuilder.Ignore<Provider>();
            modelBuilder.Ignore<RegisterUser>();
            modelBuilder.Ignore<Skill>();
            modelBuilder.Ignore<SkillLevel>();
            modelBuilder.Ignore<User>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Default> Default { get; set; }
        public DbSet<Geolocalization> Geolocalization { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<LoginUser> LoginUser { get; set; }
        public DbSet<Officer> Officer { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<RegisterUser> RegisterUser { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillLevel> SkillLevel { get; set; }
        public DbSet<User> User { get; set; }
    }
}
