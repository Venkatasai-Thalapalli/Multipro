using Microsoft.EntityFrameworkCore;

namespace WebAppCourses.Data
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {
        }

        public DbSet<WebAppCourses.Models.Course> Courses { get; set; } = default!;
    }
}
