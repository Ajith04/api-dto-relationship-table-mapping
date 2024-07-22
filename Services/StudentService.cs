using Ajith.Database;
using Ajith.DTO.Request;
using Ajith.DTO.Response;
using Ajith.Repositories;

namespace Ajith.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepo _istudentrepo;

        public StudentService(IStudentRepo istudentrepo)
        {
         _istudentrepo = istudentrepo;
        }

        public async Task<StudentResponseDTO> addStudent(StudentRequestDTO studentrequestdto)
        {
            if (studentrequestdto.StuAge > 0)
            {
                var studentrequest = new Student();
                studentrequest.StuName = studentrequestdto.StuName;
                studentrequest.StuAge = studentrequestdto.StuAge;
                studentrequest.StuEmail = studentrequestdto.StuEmail;

                var data = await _istudentrepo.addStudent(studentrequest);

                var requestsubjectlist = new List<Subject>();

                foreach(var item in studentrequestdto.Subject)
                {
                    var subject = new Subject();
                    subject.StuId = data.StuId;
                    subject.SubName = item.Name;
                    requestsubjectlist.Add(subject);
                }

                var subdata = await _istudentrepo.addSubject(requestsubjectlist);

                var subjectresponselist = new List<SubjectResponseDTO>();

                foreach (var item in subdata)
                {
                    var subjectresponse = new SubjectResponseDTO();
                    subjectresponse.Name = item.SubName;
                    subjectresponselist.Add(subjectresponse);

                }

                var response = new StudentResponseDTO
                {
                    StuID = data.StuId,
                    StuName = data.StuName,
                    StuAge = data.StuAge,
                    StuEmail = data.StuEmail,
                    Subject = subjectresponselist,
                };

                return response;
            }
            else
            {
                throw new Exception("Age must be a positive number");
            }
        }

    }
}
