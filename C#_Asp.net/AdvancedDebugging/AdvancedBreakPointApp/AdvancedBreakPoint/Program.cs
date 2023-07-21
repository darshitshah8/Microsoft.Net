using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedBreakPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunsAlot();
            Console.ReadLine();
        }
        private static void RunsAlot()
        {
            long total = 0;
            int test = 0;
            for (int i = -1000; i <= 1000; i++)
            {
                total += i;
                try
                {
                test = 5 / i;
                }
                catch
                {
                    Console.WriteLine("There was an exceptions");
                }
            }
            Console.WriteLine($"The total is {total}");
        }
    }
}


//NOTE: use advanced breakpoints to help you narrow down issues and finally find the location of the error