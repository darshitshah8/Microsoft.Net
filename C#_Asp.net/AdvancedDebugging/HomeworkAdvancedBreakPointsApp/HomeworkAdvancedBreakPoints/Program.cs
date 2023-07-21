/*
Create a console Application that loops from 1 to 100 .
throw an exception on 73.
Use a breakpoint to break before the breaking situation
 */
using System;

namespace HomeworkAdvancedBreakPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BreakThePoint();
            Console.ReadLine();
        }
        private static void BreakThePoint() 
        {
            
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    Console.WriteLine($"Number is : {i}");      
                }
                catch
                {
                    Console.WriteLine("Error Occured");
                }
            }
        }
    }
}
