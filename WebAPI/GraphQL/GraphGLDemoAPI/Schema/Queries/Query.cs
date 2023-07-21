using Bogus;
using GraphGLDemoAPI.Schema.Models;

namespace GraphGLDemoAPI.Schema.Queries
{
    public class Query
    {
        public readonly Faker<Instructor> _instructorFaker;
        public readonly Faker<Student> _studentFaker;
        public readonly Faker<Course> _courseFaker;

        public Query()
        {

            _instructorFaker = new Faker<Instructor>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Salary, f => f.Random.Double(10000, 40000));


            _studentFaker = new Faker<Student>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.GPA, f => f.Random.Double(1, 10));


            _courseFaker = new Faker<Course>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.Name, f => f.Name.JobTitle())
            .RuleFor(c => c.Subject, f => f.PickRandom<Subject>())
            .RuleFor(c => c.Instructor, f => _instructorFaker.Generate())
            .RuleFor(c => c.Students, f => _studentFaker.Generate(1));
        }
        public IEnumerable<Course> GetCourses()
        {
            return _courseFaker.Generate(2);
        }
        public async Task<Course> GetCourseByIdAsync(Guid id)
        {
            await Task.Delay(1000);
            Course course = _courseFaker.Generate();
            course.Id = id;
            return course;
        }
        [GraphQLDeprecated("This query is Deprecated")]
        public string instruction => "This is graphql";
    }
}
