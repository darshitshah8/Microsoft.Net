using System;

namespace MiniprojectHomeworkExtension
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }
            return output;
        }
        public static int RequestStandard(this string message,int minValue,int maxValue)
        {
            return message.RequestStandard(true,minValue,maxValue);
        }
        public static int RequestStandard(this string message)
        {
            return message.RequestStandard(false);
        }
        public static int RequestStandard(this string message,bool useMinMax,int minValue=0,int maxValue = 0) 
        {
            int output = 0;
            bool isValidInt = false;
            bool isValidRange = false;

            while (isValidInt == false || isValidRange == false)    
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isValidRange = (output >= minValue && output <= maxValue);
                 }
            }
            return output;

        }
    }
}
