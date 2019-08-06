using System.Collections.Generic;

namespace PjatkArchExample.Domain.Entities
{
    public class Studies
    {
        public int IdStudies { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EnrolledStudent> StudentsEnrolled { get; set; }
    }
}
