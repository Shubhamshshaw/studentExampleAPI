using APIIntegration.Models;
using APIIntegration.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIIntegration.Controllers
{
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        IStudentService studentService;
        public StudentController(IStudentService _studentService)
        {
            this.studentService = _studentService;
        }
        [Route("/health")]
        [HttpGet]
        public String Index()
        {
            return "API health is OK";
        }

        [Route("/getAllStudents")]
        [HttpGet]
        public List<Student> allStudents()
        {

            return studentService.GetAllStudents();

        }
    }
}
