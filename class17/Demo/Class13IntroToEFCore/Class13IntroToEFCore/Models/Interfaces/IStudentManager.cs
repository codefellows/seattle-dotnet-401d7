using System.Collections.Generic;
using System.Threading.Tasks;

namespace Class13IntroToEFCore.Models.Interfaces
{
    public interface IStudentManager
    {
        Task CreateStudent(Student student);

        void UpdateStudent(int id, Student student);

        void DeleteStudent(Student student);

        Task<Student> GetStudent(int id);

        Task<List<Student>> GetStudents();

        Task<List<CourseEnrollments>> GetEnrollments(int id);

        Task<List<Transcript>> GetTranscripts(int studentID);
        Task<Transcript> GetTranscript(int id);
        Task UpdateTranscipt(Transcript transcript);
        Task DeleteTranscript(int id);

        Task AddTranscript(Transcript transcript);

        bool StudentExists(int id);



    }
}
