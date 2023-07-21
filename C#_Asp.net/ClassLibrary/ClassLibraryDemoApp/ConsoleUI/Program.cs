
using CoreLibrary;

namespace ConsoleUI
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Generators generators = new Generators();
            //string message = generators.WelcomeMessage("Mr.", "Shah");
            //Console.WriteLine(message);

            PersonModel person = new PersonModel
            {
                FirstName = "Darshit",
                LastName = "Shah",
                Prefix = "Mr."
            };
            string message = generators.WelcomeMessage(person.Prefix,person.LastName);            
            string gb = generators.FareWellMessage(person.Prefix,person.LastName);            
            Console.WriteLine(message);
            Console.WriteLine(gb);

        }
        
    }
}

