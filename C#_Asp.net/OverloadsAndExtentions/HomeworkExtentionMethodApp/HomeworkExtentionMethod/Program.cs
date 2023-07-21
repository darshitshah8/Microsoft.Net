using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.SetDefaultAge(22).PrintMessage("Darshit","Shah");

            Console.ReadLine(); 
        }
    }


}
