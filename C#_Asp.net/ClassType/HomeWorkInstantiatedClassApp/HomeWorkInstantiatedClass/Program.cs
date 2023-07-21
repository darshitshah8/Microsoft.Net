using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInstantiatedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            List<AddressModel> addressList = new List<AddressModel>();
            string addresses = "";
            do
            {
                Console.Write("Enter your first name or (type exit for stop): ");
                firstName = Console.ReadLine();

                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter address (city): ");
                addresses = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    if (firstName.ToLower() == null)
                    {
                        Console.WriteLine("Please enter data");
                    }
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);

                    AddressModel addressData = new AddressModel();
                    addressData.AddressData = addresses;
                    addressList.Add(addressData) ;
                }
            } while (firstName.ToLower() != "exit");


            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"Hello {people[i].FirstName} {people[i].LastName}");
                Console.WriteLine($"You are from {addressList[i].AddressData}");
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}


            //foreach (PersonModel p in people )
            //{
            //    ProcessPerson.GreetToPerson(p);

            //}
            //foreach (AddressModel a in addressList)
            //{
            //    ProcessPerson.SayAddress(a);
            //}            