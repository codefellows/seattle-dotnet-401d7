using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Class13IntroToEFCore.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You forgot a First Name!!!!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="CAAAT!")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range(18,99)]
        
        public int Age { get; set; }

        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        // nav props
        public ICollection<CourseEnrollments> Enrollments { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }
    }
}
