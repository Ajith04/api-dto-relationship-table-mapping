namespace Ajith.DTO.Request
{
    public class StudentRequestDTO : StudentDTO
    {
        public List<SubjectRequestDTO> Subject { get; set; }

    }
}
