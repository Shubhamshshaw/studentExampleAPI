using APIIntegration.Models;
using Microsoft.EntityFrameworkCore;

namespace APIIntegration.DaoLayer.DbContextLayer
{
    public class ApplicationDbContext<T>: DbContext where T: class
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext<T>> options)
            : base(options)
        {

        }

        public DbSet<T> objectDto { get; set; }

        public List<T> GetAll()
        {
            // Execute raw SQL query
            return objectDto.FromSqlRaw("EXEC GetAllStudents").ToList();
        }
    }
}
