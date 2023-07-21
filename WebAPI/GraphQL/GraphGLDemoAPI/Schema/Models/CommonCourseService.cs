namespace GraphGLDemoAPI.Schema.Models
{

    public class CommonCourseService
    {
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public Guid InstructorId { get; set; }
    }
    public class CourseResults : CommonCourseService
    {
        public Guid Id { get; set; }
    }
    public class CourseInput : CommonCourseService
    {

    }
}