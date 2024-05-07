using COMP003B._2024SP.LectureActivity7.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B._2024SP.LectureActivity7.Data
{
    public class ProgrammingAcademyContext : DbContext
    {
        public ProgrammingAcademyContext(DbContextOptions<ProgrammingAcademyContext> options)
    : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
