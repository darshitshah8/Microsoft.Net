using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserMessages
    {
        public static void ApplicationStartingMessages(string firstName)
        {
            Console.WriteLine("Welcome to the static classes demo application");
            int hourOfDay = DateTime.Now.Hour;
            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning! {firstName}");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon! {firstName}");
            }
            else
            {
                Console.WriteLine($"Good Evening! {firstName}");
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
