using Class13IntroToEFCore.Data;
using Class13IntroToEFCore.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class13IntroToEFCore.Models.Services
{
    public class CourseService : ICourseManager
    {
        private StudentEnrollmentDbContext _context;

        public CourseService(StudentEnrollmentDbContext context)
        {
            _context = context;
        }
        public async Task CreateCourse(Course course)
        {
            _context.Add(course);
            await _context.SaveChangesAsync();

        }
        public async Task<List<Course>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return null;
            }

            return course;

        }

        public bool DeleteCourse(int id)
        {
            var course = _context.Courses.Where(x => x.ID == id);
            if (course != null)
            {
                _context.Remove(course);
                _context.SaveChanges();
            }
            return true;
        }


        public void UpdateCourse(int id, Course course)
        {
            if (course.ID == id)
            {
                _context.Courses.Update(course);
                _context.SaveChanges();
            }

        }

        public Transcript GetTranscript(int id)
        {
            // _context.Transcripts

            return null;
        }

        public List<Transcript> GetAllTranscripts()
        {
            return null;
        }

        public bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.ID == id);
        }
    }
}
