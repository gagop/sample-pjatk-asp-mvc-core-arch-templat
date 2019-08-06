using System;
using System.Collections.Generic;

namespace PjatkArchExample.Domain.Entities
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<EnrolledStudent> StudentEnrolled { get; set; }
    }
}
