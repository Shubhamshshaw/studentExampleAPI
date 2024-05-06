using APIIntegration.Models;
using APIIntegration.DaoLayer.DbContextLayer;

namespace APIIntegration.DaoLayer
{
    public class StudentDao : IStudentDao
    {
        private readonly ApplicationDbContext<Student> context;
        public StudentDao(ApplicationDbContext<Student> _context)
        {
            this.context = _context;
        }
        public List<Student> GetAll()
        {
            return context.GetAll().ToList();
        }
    }
}
