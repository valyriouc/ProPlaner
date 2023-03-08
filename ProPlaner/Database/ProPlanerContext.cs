

using Microsoft.EntityFrameworkCore;

namespace ProPlaner.Database
{

    public class ProPlanerContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Promodoro> Promodoros { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public ProPlanerContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) =>
            builder.UseMySql("host=localhost; port=3306;database=SimpleNoteDb;user=root;password=\\zCK=%CId-*=ySECJQ&2*kUlrbL:v823lMxg&y9o", new MySqlServerVersion(new Version(8, 0, 11)));
    }
}