using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            apple.OsSystem = "IOS";

            Windows windows = new Windows();
            string companyName = windows.Company = "Dell";

            Console.WriteLine(apple.OsSystem);
            Console.WriteLine(companyName);


            Console.ReadLine();
        }
        public abstract class Laptop
        {
            public int Ram { get; set; }
            public int Storage { get; set; }
            public decimal Version { get; set; }
            public string OsSystem { get; set; }
        }
        public class Apple : Laptop
        {
            
        }
        public class Windows : Laptop
        {
            public string Company { get; set; }
        }
    }
}
