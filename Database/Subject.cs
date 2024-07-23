using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ajith.Database
{
    public class Subject
    {
        [Key] public Guid SubId { get; set; }

        public string SubName { get; set; }

        public Guid StudentStuId {  get; set; }
    }
}
