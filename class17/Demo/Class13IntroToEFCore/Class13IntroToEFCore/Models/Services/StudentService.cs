using Class13IntroToEFCore.Data;
using Class13IntroToEFCore.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class13IntroToEFCore.Models.Services
{
    public class StudentService : IStudentManager
    {
        private StudentEnrollmentDbContext _context;

        public StudentService(StudentEnrollmentDbContext context)
        {
            _context = context;
        }
        public async Task CreateStudent(Student student)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
        }

        public void DeleteStudent(Student student)
        {
            _context.Remove(student);
            _context.SaveChanges();
        }

        public async Task<List<CourseEnrollments>> GetEnrollments(int id)
        {
            return await _context.CourseEnrollments.Where(st => st.StudentID == id).ToListAsync();
        }

        public async Task<Student> GetStudent(int id)
        {
            Student student = await _context.Students
                                            .Include(t => t.Transcripts)
                                            .ThenInclude(x => x.Course)
                                            .Include(t => t.Enrollments)
                                            .FirstOrDefaultAsync(m => m.ID == id);

            return student;

        }

        public async Task<List<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public void UpdateStudent(int id, Student student)
        {
            if (id == student.ID)
            {
                _context.Update(student);
                _context.SaveChanges();
            }
        }

        public bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.ID == id);
        }

        public async Task<List<Transcript>> GetTranscripts(int id)
        {
            return await _context.Transcripts
                           .Where(tran => tran.StudentID == id).ToListAsync();
        }

        public async Task<Transcript> GetTranscript(int id)
        {
            return await _context.Transcripts.FirstOrDefaultAsync(x => x.ID == id);
        }


        public async Task DeleteTranscript(int id)
        {
            var trans = await GetTranscript(id);

            _context.Transcripts.Remove(trans);
        }


        public async Task AddTranscript(Transcript transcript)
        {
            _context.Add(transcript);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTranscipt(Transcript transcript)
        {
            _context.Update(transcript);
            await _context.SaveChangesAsync();
        }
    }
}
