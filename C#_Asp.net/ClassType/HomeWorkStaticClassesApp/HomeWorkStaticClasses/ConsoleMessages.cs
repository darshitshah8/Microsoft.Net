
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStaticClasses
{
    public static class ConsoleMessages
    {
        public static void ApplicationOutput()
        {
            Console.WriteLine("Welcome to the static classes demo application");
            int hourOfDay = DateTime.Now.Hour;
            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon!");
            }
            else
            {
                Console.WriteLine($"Good Evening!");
            }

        }
        public static void GoodByeMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("thank you for using our calculation application");
        }

    }
}
