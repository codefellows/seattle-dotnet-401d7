using System.Collections.Generic;
using System.Threading.Tasks;

namespace Class13IntroToEFCore.Models.Interfaces
{
    public interface ICourseManager
    {
        // Create a course
        Task CreateCourse(Course course);

        // Update a Course
        void UpdateCourse(int id);

        // Delete a course
        bool DeleteCourse(int id);

        // Get a single course
        Task<Course> GetCourse(int id);

        // get all the courses
        Task<List<Course>> GetCourses();

        Transcript GetTranscript(int id);

        List<Transcript> GetAllTranscripts();


    }
}
