using Ajith.DTO.Request;
using Ajith.DTO.Response;

namespace Ajith.Services
{
    public interface IStudentService
    {
        Task<StudentResponseDTO> addStudent(StudentRequestDTO studentrequestdto);
    }
}
