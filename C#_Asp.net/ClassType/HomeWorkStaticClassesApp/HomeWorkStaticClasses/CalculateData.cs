using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStaticClasses
{
    public class CalculateData
    {
        public static double Mathematics(double x, double y)
        {
            Console.WriteLine($"Enter your request");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUB");
            Console.WriteLine("3. MUL");
            Console.WriteLine("4. DIV");
            string option = Console.ReadLine();
            bool isValidOption = Double.TryParse(option, out double value);
            double ans = 0;
           
            switch(value)
            {
                case 1:
                    Console.WriteLine("You choose addition");
                    ans = x + y;                    
                    Console.WriteLine($"{x} + {y} = {ans}");
                    break;
                case 2:
                    Console.WriteLine("You choose Substraction");
                    ans = x - y;
                    Console.WriteLine($"{x} - {y} = {ans}");
                    break;
                case 3:
                    Console.WriteLine("You choose Multiplication");
                    ans = x * y;
                    Console.WriteLine($"{x} * {y} = {ans}");
                    break;
                case 4:
                    Console.WriteLine("You choose Division");
                    ans = x / y;
                    Console.WriteLine($"{x} / {y} = {ans}");
                    break;
                default:
                    Console.WriteLine("enter valid choice");
                    break;
            }
            return ans;

        }
    }
}
