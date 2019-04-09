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

            // Seeding Data
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    ID = 1,
                    FirstName = "Big Bird",
                    LastName = "Yellow",
                    Age = 50
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Miss Piggy",
                    LastName = "Muppet",
                    Age = 44

                },
                new Student
                {
                    ID = 3,
                    FirstName = "Kermit",
                    LastName = "The Frog",
                    Age = 65
                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    Name = "Underwater Basket Weaving",
                    Price = 10.00m,
                    Tech = Technology.Dotnet
                },
                new Course
                {
                    ID = 2,
                    Name = "Intro To Azure",
                    Price = 50.00m,
                    Tech = Technology.Python
                }
               );
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollments> CourseEnrollments { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }

    }
}
