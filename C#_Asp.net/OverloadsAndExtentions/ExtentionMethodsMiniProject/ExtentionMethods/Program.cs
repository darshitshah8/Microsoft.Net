using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Enter your first name : ".RequestString();

            person.LastName = "Enter your last name : ".RequestString();

            person.Age = "Enter your age :  ".RequestInt(0,120);

            //person.Age = ConsoleHelper.RequestInt("enter your age" , 0,100);

            Console.ReadLine();
        }
    }
}
