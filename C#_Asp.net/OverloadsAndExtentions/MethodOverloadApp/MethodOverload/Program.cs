using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("darshit","shah");
            
            //without parameter
            person.GenerateEmail();
            Console.WriteLine(person.Email);

            // with domain
            person.GenerateEmail("aimdek.ac.in");
            Console.WriteLine(person.Email);

            // With bool
            person.GenerateEmail(true);
            Console.WriteLine(person.Email);

            // With domain and initial firstInitial
            person.GenerateEmail("gmail.com",true);
            Console.WriteLine(person.Email);  




            Console.ReadLine();
        }
    }
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {
            
        }
        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;            
        }
        public PersonModel(string firstName , string lastName , string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }


        public void GenerateEmail()
        {
            GenerateEmail("@gmail.com",true);
        }
        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitialMethosd) 
        {
            GenerateEmail("@gmail.com",firstInitialMethosd);
        }
        public void GenerateEmail(string domain,bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)}{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}{LastName}@{domain}";
            }
        }
    }
}
