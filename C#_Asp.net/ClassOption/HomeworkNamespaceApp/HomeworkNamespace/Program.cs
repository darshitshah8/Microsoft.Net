using PersoneModelNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            double addition = CalculationNS.Calculation.Add(4, 5);
            Console.WriteLine(addition);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
