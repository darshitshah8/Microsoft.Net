using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Our app thrown the exceptions ");
                Console.WriteLine(ex.Message);
                throw;
            }
            
            Console.ReadLine();
        }
        private static void BadCall()
        {   
            int[] ages = new int[] {23,22,18};
            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine($"ages are {ages[i]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("We had an error");
                    Console.WriteLine(ex.Message);
                    throw new Exception ("there was error handling exception in our array", ex);
                }
            }
        }
    }
}



//NOTE: Don't blindly catch and ignore exceptions and don't be afraid to close the application