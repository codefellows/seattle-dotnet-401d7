using Class13IntroToEFCore.Data;
using Class13IntroToEFCore.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }


        public void UpdateCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Transcript GetTranscript(int id)
        {
            // _context.Transcripts

            return null;
        }

        public List<Transcript> GetAllTranscripts()
        {
            throw new NotImplementedException();
        }
    }
}
