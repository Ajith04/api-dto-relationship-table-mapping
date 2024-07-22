using Ajith.Database;

namespace Ajith.Repositories
{
    public interface IStudentRepo
    {
        Task<Student> addStudent(Student student);
        Task<List<Subject>> addSubject(List<Subject> subject);
    }
}
