using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStaticClasses
{
    internal class RequestData
    {
        public static double GetADoubleInput(string message)
        {
            Console.WriteLine(message);
            string numberText = Console.ReadLine();
            double output = 0;
            bool inValidInput = double.TryParse(numberText, out output);
            while (inValidInput == false)
            {
                Console.WriteLine("Sorry, Invalid input!! please enter the valid input");
                Console.WriteLine(message);
                numberText = Console.ReadLine();
                inValidInput = double.TryParse(numberText, out output);
            }
            return output;
        }

    }
}
