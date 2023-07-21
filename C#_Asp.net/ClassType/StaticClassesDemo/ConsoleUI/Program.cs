using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{       
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetUserName("what is your name");
            UserMessages.ApplicationStartingMessages(firstName);


            double x = RequestData.GetADoubleInput("Enter the first number");
            double y = RequestData.GetADoubleInput("Enter the first number");

            double add = CalculateData.AddNumbers(x, y);
            double sub = CalculateData.SubNumbers(x, y);

            UserMessages.GoodByeMessage($"The sum of {x} and {y} is {add} .");
            Console.ReadLine();
        }   
    }
}
