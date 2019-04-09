using System.Collections.Generic;
using System.Threading.Tasks;

namespace Class13IntroToEFCore.Models.Interfaces
{
    public interface ICourseManager
    {
        /// <summary>
        /// Create and adds a new course into the database
        /// </summary>
        /// <param name="course">The new course to be added/saved</param>
        /// <returns>a task of completion</returns>
        Task CreateCourse(Course course);

        // Update a Course
        void UpdateCourse(int id, Course course);

        // Delete a course
        bool DeleteCourse(int id);

        // Get a single course
        Task<Course> GetCourse(int id);

        // get all the courses
        Task<List<Course>> GetCourses();

        Transcript GetTranscript(int id);

        List<Transcript> GetAllTranscripts();

        bool CourseExists(int id);


    }
}
