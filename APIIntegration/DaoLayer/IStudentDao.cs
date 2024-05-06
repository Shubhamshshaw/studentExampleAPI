using APIIntegration.Models;

namespace APIIntegration.DaoLayer
{
    public interface IStudentDao
    {
        public List<Student> GetAll();
    }
}
