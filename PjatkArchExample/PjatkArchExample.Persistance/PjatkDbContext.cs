using Microsoft.EntityFrameworkCore;
using PjatkArchExample.Domain.Entities;

namespace PjatkArchExample.Persistance
{
    public class PjatkDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Studies> Studies { get; set; }
        public DbSet<EnrolledStudent> StudentsEnrolled { get; set; }

        public PjatkDbContext() { }

        public PjatkDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //TODO setup of in-memory database just for testing purposes
            optionsBuilder.UseInMemoryDatabase("SampleDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PjatkDbContext).Assembly);
        }
    }
}
