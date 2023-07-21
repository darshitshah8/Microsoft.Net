using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PersoneModel people = new PersoneModel();
            people.FirstName = "darshit";
            people.LastName = "Shah";

            Console.WriteLine($" hello {people.FirstName} {people.LastName}");
            Console.ReadLine();
        }
    }
}
