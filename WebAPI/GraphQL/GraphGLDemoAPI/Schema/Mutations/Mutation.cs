using GraphGLDemoAPI.DTOs;
using GraphGLDemoAPI.Schema.Models;
using GraphGLDemoAPI.Schema.Repository;
using HotChocolate.Subscriptions;
using System.Runtime.CompilerServices;

namespace GraphGLDemoAPI.Schema.Mutations
{
    public class Mutation
    {
        private readonly CourseRepo _courseRepo;

        public Mutation(CourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public async Task<CourseResults> CreateCourse(CourseInput courseInput, [Service] ITopicEventSender topicEventSender, List<CourseRepo> _course)
        {
            CourseDto courseDto = new CourseDto()
            {
                Name = courseInput.Name,
                Subject = (DTOs.Subject)courseInput.Subject,
                InstructorId = courseInput.InstructorId,
            };
            courseDto = await _courseRepo.Create(courseDto);
            CourseResults courseResults = new CourseResults()
            {
                Id = courseDto.Id,
                Name = courseDto.Name,
                Subject = (Models.Subject)courseDto.Subject,
                InstructorId = courseDto.InstructorId
            };
            await topicEventSender.SendAsync(nameof(Subcription.Subcription.CourseCreated), courseResults);
            return courseResults;
        }
        public async Task<CourseResults> UpdateCourse(Guid id, CourseInput courseInput)
        {
            CourseDto courseDto = new CourseDto()
            {
                Id = id,
                Name = courseInput.Name,
                Subject = (DTOs.Subject)courseInput.Subject,
                InstructorId = courseInput.InstructorId,
            };
            courseDto = await _courseRepo.Update(courseDto);

            CourseResults courseResults = new CourseResults()
            {
                Id = courseDto.Id,
                Name = courseDto.Name,
                Subject = (Models.Subject)courseDto.Subject,
                InstructorId = courseDto.InstructorId
            };
            return courseResults;
        }
        public async Task<bool> DeleteCourse(Guid id)
        {
            return await _courseRepo.Delete(id);
        }
    }
}
