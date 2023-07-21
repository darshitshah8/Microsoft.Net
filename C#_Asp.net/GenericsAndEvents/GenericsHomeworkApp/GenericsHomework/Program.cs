using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name  = Console.ReadLine();
            string result = OddEven(name);
            Console.WriteLine($"Test Result : {result}");

            Console.ReadLine();
        }
        private static string OddEven<T>(T item)
        {
            int intLength = item.ToString().Length;
            string output = "";
            if (intLength % 2 == 0)
            {
                output += "even";
            }
            else
            {
                output += "odd";
            }
            return output;
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public int IdNumber { get; set; }
    }
}
