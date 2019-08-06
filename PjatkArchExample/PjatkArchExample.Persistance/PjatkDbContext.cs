using Microsoft.EntityFrameworkCore;
using PjatkArchExample.Domain.Entities;

namespace PjatkArchExample.Persistance
{
    public class PjatkDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Studies> Studies { get; set; }
        public DbSet<EnrolledStudent> StudentsEnrolled { get; set; }

        public PjatkDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
