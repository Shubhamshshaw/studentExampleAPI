using APIIntegration.DaoLayer;
using APIIntegration.Models;

namespace APIIntegration.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentDao studentDao;
        public StudentService(IStudentDao studentDao)
        {
            this.studentDao = studentDao;
        }
        public List<Student> GetAllStudents()
        {
            return studentDao.GetAll();
        }

    }
}
