using GraphGLDemoAPI.Data;
using GraphGLDemoAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace GraphGLDemoAPI.Schema.Repository
{
    public class CourseRepo
    {
        private readonly IDbContextFactory<SchoolDbContext> _context;

        public CourseRepo(IDbContextFactory<SchoolDbContext> context)
        {
            _context = context;
        }

        public async Task<CourseDto> Create(CourseDto course)
        {

            using (SchoolDbContext context = _context.CreateDbContext()) 
            {
                context.Add(course);
                await context.SaveChangesAsync();
                return course;
            }   
        }
        public async Task<CourseDto> Update(CourseDto course)
        {
           using (SchoolDbContext context = _context.CreateDbContext())
            {
                context.Update(course);
                await context.SaveChangesAsync();
                return course;
            }
            
        }
        public async Task<bool> Delete(Guid id)
        {
            using (SchoolDbContext context = _context.CreateDbContext())
            {
                CourseDto course = new CourseDto()
                {
                    Id = id
                };
                context.Remove(course);

                return await context.SaveChangesAsync() > 0;
            }

        }
    }
}
