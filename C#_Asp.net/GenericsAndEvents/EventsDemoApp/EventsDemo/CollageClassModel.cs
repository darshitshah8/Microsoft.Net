using System;
using System.Collections.Generic;

namespace EventsDemo
{
    public class CollageClassModel
    {
        public event EventHandler<string> EnrollmentFull;
        
        
        public List<string> enrolledStudents = new List<string>();
        public List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; set; }

        public CollageClassModel(string courseTitle, int maximumStudents)
        {
            CourseTitle = courseTitle;
            MaximumStudents = maximumStudents;  

        }
        public string SignUpStudents(string studentName)
        {
            string output = "";
            if (enrolledStudents.Count < MaximumStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} is enrolled in {CourseTitle} ";
                if (enrolledStudents.Count == MaximumStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full");
                    return "";
                }
            }
            else
            {
                                                                              //? = if is not null do next things
                waitingList.Add(studentName);
                output = $"{studentName} was added to the wait list in {CourseTitle}";
            }
            return output;

                        
        }
    }
}
