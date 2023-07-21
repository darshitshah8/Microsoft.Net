using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniprojectHomeworkExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentModel student = new StudentModel();

            student.FirstName = "What is your first name :  ".RequestString();
            student.LastName =  "what is your last name : ".RequestString();    
            student.Standard = "Which standard : ".RequestStandard(1,12);

            Console.WriteLine($"{student.FirstName} {student.LastName} from {student.Standard}th standard");

            Console.ReadLine();

        }
    }
}
