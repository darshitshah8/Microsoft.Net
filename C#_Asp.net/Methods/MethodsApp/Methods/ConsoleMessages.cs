using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ConsoleMessages
    {
        //CREATING METHODS
        public static void SayHello()
        {
            Console.WriteLine("Hello User");
        }
        public static void SayHelloByParameter(string firstName)
        {
            Console.WriteLine($"Hello {firstName}");
        }
        public static void AskName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} Welcome");
        }
        public static string GetUserName()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        //PRACTICE METHOD
        public static void AskAge() 

        {
            int validAgeNum;
            string age;
            bool validAge;
            do
            {
                Console.WriteLine("What is your age");
                age = Console.ReadLine();
                validAge = int.TryParse(age, out validAgeNum);
                if (validAge == false)
                {
                    Console.WriteLine("Enter the valid age");
                }
                else if (validAgeNum < 18)
                {
                    Console.WriteLine("not having driving licence");
                    //break;
                }
                else
                {
                    Console.WriteLine("You are holding driving licence");
                    //break;
                } 
            } while (validAge == false);
        }
        // METHOD TUPPLES = return two or more parameter as value 
        public static (string,string) GetFullName()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            return (firstName ,lastName);
        }

    }
}



//NOTE:
    // ConsoleMessages is class and class name should be same as file name
    // In class , AskName and SayHello is method of class you can call method of class in different fils by using MethodName