using Class13IntroToEFCore.Data;
using Class13IntroToEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Xunit;

namespace CourseController
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetCourse()
        {
            DbContextOptions<StudentEnrollmentDbContext> options = new DbContextOptionsBuilder<StudentEnrollmentDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (StudentEnrollmentDbContext context = new StudentEnrollmentDbContext(options))
            {
                // Arrange
                Course course = new Course();
                course.Name = "Tap Dancing for Clowns";
                course.Price = 100m;
                course.Tech = Technology.Python;

                context.Add(course);
                context.SaveChanges();

                // Act
                var result = context.Courses.FirstOrDefault(m => m.ID == course.ID);

                // Assert

                Assert.Equal(result, course);


            };
        }
    }
}
