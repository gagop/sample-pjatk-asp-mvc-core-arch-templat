using System;

namespace PjatkArchExample.Domain.Entities
{
    public class EnrolledStudent
    {
        public int IdEnrolledStudent { get; set; }
        public int IdStudies { get; set; }
        public int IdStudent { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Student Student { get; set; }
        public virtual Studies Studies { get; set; }
    }
}
