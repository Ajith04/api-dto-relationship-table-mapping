using System.ComponentModel.DataAnnotations;

namespace Ajith.DTO.Response
{
    public class SubjectResponseDTO
    {
        [Key] public Guid SubId { get; set; }
        public string Name { get; set; }

    }
}
