using Class13IntroToEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Class13IntroToEFCore.Data
{
    public class StudentEnrollmentDbContext : DbContext
    {
        public StudentEnrollmentDbContext(DbContextOptions<StudentEnrollmentDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this is the establishment of our composite key
            modelBuilder.Entity<CourseEnrollments>().HasKey(ce => new { ce.CourseID, ce.StudentID });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollments> CourseEnrollments { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }

    }
}
