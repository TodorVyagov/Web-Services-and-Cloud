namespace StudentSystem.Data.Repositories
{
    using System.Linq;

    using StudentSystem.Models;

    public class CourseRepository : Repository<Student>, IRepository<Student>
    {
        public CourseRepository(IStudentSystemDbContext context)
            : base(context)
        { 
        }
    }
}
