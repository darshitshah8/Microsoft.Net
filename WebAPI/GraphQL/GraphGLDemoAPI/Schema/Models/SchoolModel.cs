namespace GraphGLDemoAPI.Schema.Models
{

    public class BasicField
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        [GraphQLNonNullType]
        public Instructor Instructor { get; set; }
        public IEnumerable<Student> Students { get; set; }

    }
    public class Instructor : BasicField
    {
        public double Salary { get; set; }
    }
    public class Student : BasicField
    {
        [GraphQLName("gpa")]
        public double GPA { get; set; }
    }
}
