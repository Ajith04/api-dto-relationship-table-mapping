using System.ComponentModel.DataAnnotations;

namespace Ajith.Database
{
    public class Student
    {
        [Key] public Guid StuId { get; set; }
        public string StuName { get; set; }
        public int StuAge { get; set; }
        public string StuEmail { get; set; }
        public List<Subject> Subjects { get; set; }

    }
}
