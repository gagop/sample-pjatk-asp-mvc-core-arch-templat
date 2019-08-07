using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PjatkArchExample.Domain.Entities;

namespace PjatkArchExample.Persistance.Configurations
{
    public class EnrolledStudentEntityTypeConfiguration : IEntityTypeConfiguration<EnrolledStudent>
    {
        public void Configure(EntityTypeBuilder<EnrolledStudent> builder)
        {
            builder.HasKey(es => es.IdEnrolledStudent);

            builder.HasOne(es => es.Student)
                   .WithMany(s => s.StudentEnrolled)
                   .HasForeignKey(es => es.IdStudent);

            builder.HasOne(es => es.Studies)
                   .WithMany(s => s.StudentsEnrolled)
                   .HasForeignKey(es => es.IdStudies);
        }
    }
}
