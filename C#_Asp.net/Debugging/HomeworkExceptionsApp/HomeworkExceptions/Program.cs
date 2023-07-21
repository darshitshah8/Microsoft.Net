/*
 create a console application with for loop that 
throw an exceptionn after five interaction. Catch the exception
 */


using System;
namespace HomeworkExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"there is exception in our app {ex.Message}");
                //throw;
            }
            Console.ReadLine();
            
        }
        private static void BadCall()
        {
            int[] ages = new int[] {4,5,6,7,2 };
            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine($"{ages[i]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw new Exception("There is exception in our application", ex);
                }
            }
        }
    }
}
