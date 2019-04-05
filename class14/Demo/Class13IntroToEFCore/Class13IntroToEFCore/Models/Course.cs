using System.Collections.Generic;

namespace Class13IntroToEFCore.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Technology Tech { get; set; }

        // Navigation Properties
        public ICollection<CourseEnrollments> Enrollments { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }
    }

    public enum Technology
    {
        Dotnet,
        Python,
        Java,
        Javascript
    }
}
