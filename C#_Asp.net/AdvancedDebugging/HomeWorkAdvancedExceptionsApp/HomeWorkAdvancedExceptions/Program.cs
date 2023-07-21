using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAdvancedExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = "";
                Console.WriteLine("enter name");
                name = Console.ReadLine();
                InvalidInput(name);
            //DemoExceptions();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        
        private static void DemoExceptions()
        {
            throw new NotImplementedException();
        }
        private static void InvalidInput(string name)
        {
            if (name == "darshit") 
            {
                throw new Exception($"Hello {name}");
            }
            else
            {
            throw new InvalidDataException($"Sorry {name}, you are not allowed in party");

            }
           
        }

    }
}
