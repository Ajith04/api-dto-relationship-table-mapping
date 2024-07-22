using System.ComponentModel.DataAnnotations;

namespace Ajith.Database
{
    public class Subject
    {
        [Key]public Guid StuId { get; set; }

        public string SubName { get; set; }
    }
}
