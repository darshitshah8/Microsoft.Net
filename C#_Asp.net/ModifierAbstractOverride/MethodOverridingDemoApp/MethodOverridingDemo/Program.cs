using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MethodOverridingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Darshit",
                LastName = "Shah",
                Email = "darshit.shah@joogle.com"

            };
            Console.WriteLine(person);

            Corrola collora = new Corrola();
            
            Console.ReadLine();

    }
        }
}
