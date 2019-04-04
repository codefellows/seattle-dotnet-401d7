using System.Collections.Generic;

namespace Class13IntroToEFCore.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // nav props
        public ICollection<CourseEnrollments> Enrollments { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }
    }
}
