/*
 Create console applications with a for loop
that multiplies a number by five and adds it to the 
total each time . step through the code
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDebugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 1; i++)
            { 
                for (int j = 0; j < 10; j++) // change i to j 
                {
                count = j * 5;
                Console.WriteLine($"{i}th time count is {count}");
                }
            }
            Console.ReadLine();
        }
    }
}
