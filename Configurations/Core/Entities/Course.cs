using System;
using System.Collections.Generic;

namespace Tutorial.Core.Entities
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; private set; }

        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }
    }
}
