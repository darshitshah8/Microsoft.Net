using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Darshit",
                LastName = "Shah"
            };
            Console.WriteLine(person);
            Marks marks = new Marks
            {
                Low = 12,
                High = 13,
            };
            Console.WriteLine(marks);

           Console.ReadLine();
        }
    }
}
