using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Methods
{
    public class MathsShortCut
    {
        // METHOD PARAMETERS

        public static double Add(double x, double y)
        {
            //RETURNING VALUE
            //Console.WriteLine($"{x} + {y} = {x + y}");
            double add = x + y;
            return add;
        }
        public static void Sub(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public static void Mul(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }
        public static void Div(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public static void AddAll(double[] values)
        {
            double result = 0;
            //values.Sum();
            foreach (double value in values)
            {
                result += value;
            }
            Console.WriteLine($"The total is {result}");
        }
    }
}
