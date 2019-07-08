using System;
using System.Collections.Generic;

namespace Tutorial.Core.Entities
{
    public class Student
    {
        public Guid ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }
    }
}
