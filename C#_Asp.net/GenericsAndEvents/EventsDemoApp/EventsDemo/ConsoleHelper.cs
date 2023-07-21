using System;

namespace EventsDemo
{
    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            if (message.Length !=0)
            {
            Console.WriteLine(message);

            }
        }
    }
}
