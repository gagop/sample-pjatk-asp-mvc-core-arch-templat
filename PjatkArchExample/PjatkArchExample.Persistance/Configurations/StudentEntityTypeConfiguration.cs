using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PjatkArchExample.Domain.Entities;

namespace PjatkArchExample.Persistance.Configurations
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.IdStudent);
            builder.Property(s => s.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(s => s.LastName).IsRequired().HasMaxLength(100);

            builder.HasMany(s => s.StudentEnrolled)
                   .WithOne(se => se.Student)
                   .HasForeignKey(se => se.IdStudent);
        }
    }
}
