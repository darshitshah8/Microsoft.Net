using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClass
{
    public class ProcessPerson
    {
        public static void GreetToPerson(PersonModel person)
        {
            Console.WriteLine($"Hello, {person.FirstName} {person.LastName}");
            person.Greeted = true;
        }
    }
}
