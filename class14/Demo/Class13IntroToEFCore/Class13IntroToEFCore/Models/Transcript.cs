namespace Class13IntroToEFCore.Models
{
    public class Transcript
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Grade Grade { get; set; }
        public bool Pass { get; set; }

        // Nav Props

        public Course Course { get; set; }
        public Student Student { get; set; }
    }



    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }
}
