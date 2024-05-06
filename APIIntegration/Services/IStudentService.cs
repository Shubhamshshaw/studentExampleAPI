using APIIntegration.Models;

namespace APIIntegration.Services
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
    }
}
