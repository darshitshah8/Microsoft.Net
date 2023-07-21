using GraphGLDemoAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace GraphGLDemoAPI.Data
{
    public class SchoolDbContext :DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<CourseDto> Courses {get; set;}
        public DbSet<InstructorDto> Instructors {get; set;}
        public DbSet<StudentDto> Students {get; set;}

    }
}
