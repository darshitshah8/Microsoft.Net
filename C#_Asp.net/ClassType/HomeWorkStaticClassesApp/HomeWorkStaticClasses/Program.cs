using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStaticClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x = RequestData.GetADoubleInput("Enter the first number");
            double y = RequestData.GetADoubleInput("Enter the first number");

            double ans = CalculateData.Mathematics(x, y);
            

            ConsoleMessages.GoodByeMessage($"The sum of {x} and {y} is {ans} .");
            Console.ReadLine();

        }
    }
}
