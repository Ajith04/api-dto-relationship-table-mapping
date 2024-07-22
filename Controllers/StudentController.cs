using Ajith.DTO.Request;
using Ajith.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ajith.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _istudentservice;

        public StudentController(IStudentService istudentservice)
        {
            _istudentservice = istudentservice;
        }

        [HttpPost ("add-student")]

        public async Task<IActionResult> addStudent(StudentRequestDTO studentrequestdto)
        {
            try
            {
                var data = await _istudentservice.addStudent(studentrequestdto);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
