namespace Ajith.DTO.Response
{
    public class StudentResponseDTO : StudentDTO
    {
        public Guid StuID { get; set; }
        public List<SubjectResponseDTO> Subject { get; set; }
    }
}
