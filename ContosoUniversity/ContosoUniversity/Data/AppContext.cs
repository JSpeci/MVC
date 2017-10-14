using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class AppContext : DbContext
    {
        public AppContext( DbContextOptions<AppContext> options ) : base( options )
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Group>( ).ToTable( "Groups" );
            modelBuilder.Entity<Person>( ).ToTable( "Person" );
        }
    }
}