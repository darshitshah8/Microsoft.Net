
namespace GraphGLDemoAPI.DTOs;

public enum Subject
{
    Math,
    Science,
    History
}

public class BasicField
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
public class CourseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Subject Subject { get; set; }
    public Guid InstructorId { get; set; }
    public InstructorDto Instructor { get; set; }
    public IEnumerable<StudentDto> Students { get; set; }
}
public class InstructorDto : BasicField
{
    public double Salary { get; set; }
    public IEnumerable<CourseDto> Courses { get; set; }
}
public class StudentDto : BasicField
{
    public IEnumerable<CourseDto> Courses { get; set; }
    public double GPA { get; set; }
}
