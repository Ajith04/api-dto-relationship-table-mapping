using Ajith.Database;
using Ajith.DTO.Request;
using System.ComponentModel;

namespace Ajith.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private SchoolDbContext _SchoolDbContext { get; set; }

        public StudentRepo(SchoolDbContext schooldbcontext)
        {
            _SchoolDbContext = schooldbcontext;
        }

        public async Task<Student> addStudent(Student student)
        {
            await _SchoolDbContext.Students.AddAsync(student);
            await _SchoolDbContext.SaveChangesAsync();
            return student;

        }

        public async Task<List<Subject>> addSubject(List<Subject> subject)
        {
            await _SchoolDbContext.Subjects.AddRangeAsync(subject);
            await _SchoolDbContext.SaveChangesAsync();
            return subject;
        }

    }
}
