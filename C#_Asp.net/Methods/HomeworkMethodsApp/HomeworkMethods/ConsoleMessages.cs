using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeworkMethods
{
    public class ConsoleMessages
    {
        public static void WelcomeMessage() 
        {
            Console.WriteLine("Hello User");
        }
        //public static void AskUserName()
        //{
        //    Console.WriteLine("What is your name");
            
        //}
        public static string AskUserName()
        {
            Console.WriteLine("Enter first name");
            string name = Console.ReadLine();
            return name;
        }
        public static void HelloUser(string name)
        {
            Console.WriteLine($" Hello {name}");
        }
    }
}
