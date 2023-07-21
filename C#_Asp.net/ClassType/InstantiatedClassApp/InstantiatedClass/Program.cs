using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClass
{
    internal class Program
    {
        //Building house from blueprint 
        public static void Main(string[] args)
        {
            //List<PersonModel> people = new List<PersonModel>();  
            
            //PersonModel person = new PersonModel();
            //person.firstName = "tim";
            //person.lastName = "corey";
            //people.Add(person);

            //person = new PersonModel();
            //person.firstName = "bob";
            //person.lastName = "the builder";
            //people.Add(person);

            //foreach(PersonModel p in people)
            //{
            //    Console.WriteLine($"{p.firstName} {p.lastName}");
                               
            //}
            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            do
            {
                Console.Write("Enter your first name or (type exit for stop): ");
                firstName = Console.ReadLine();

                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetToPerson(p);
            }
            Console.ReadLine();
        }
    }
}
