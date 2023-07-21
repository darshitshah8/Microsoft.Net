using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CollageClassModel physics = new CollageClassModel("Physics 101", 4);
            CollageClassModel maths = new CollageClassModel("Maths 102",2);
            

            physics.EnrollmentFull += CollageClass_EnrollmentFull;

            physics.SignUpStudents("joe").PrintToConsole();
            physics.SignUpStudents("kai").PrintToConsole();
            physics.SignUpStudents("Zark").PrintToConsole();
            physics.SignUpStudents("bob").PrintToConsole();
            physics.SignUpStudents("Tony").PrintToConsole();
            Console.WriteLine();

            maths.EnrollmentFull += CollageClass_EnrollmentFull;

            maths.SignUpStudents("Zark").PrintToConsole();
            maths.SignUpStudents("James").PrintToConsole();
            maths.SignUpStudents("Gim").PrintToConsole();
            maths.SignUpStudents("Joe").PrintToConsole();
            

            

            Console.ReadLine();
        }

        private static void CollageClass_EnrollmentFull(object sender, string e)
        {
            CollageClassModel model = (CollageClassModel)sender;

            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle} : Full");
            Console.WriteLine();
        }
    }
}
