using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace HomeworkTextFileUI
{
    class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        public static TextFileDataAccess db = new TextFileDataAccess();
        public static void Main(string[] args)
        {

            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");
            PersonModel user1 = new PersonModel();
            user1.FirstName = "Darshit";
            user1.LastName = "Shah";
            user1.EmailAddress = "ds@my.com";
            user1.PhoneNumber = "0978634123";


            PersonModel user2 = new PersonModel();
            user2.FirstName = "Tim";
            user2.LastName = "Corey";
            user2.EmailAddress = "tc@my.com";

            user2.PhoneNumber = "0978634234";


            //CreateContact(user1);
            //CreateContact(user2);
            UpdateContectFirstName("Darshitt");
            ReadAllContact();
            RemoveUser();
            ReadAllContact();



            Console.WriteLine("Process Done");
        }
        //CRUD = CREATE , READ , UPDATE , DELETE

        // CREATE 
        private static void CreateContact(PersonModel contact)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.Add(contact);
            db.WriteAllRecords(contacts, textFile);
        }

        // READ
        private static void ReadAllContact()
        {
            var contacts = db.ReadAllRecords(textFile);
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName}");
            }
        }

        // UPDATE
        private static void UpdateContectFirstName(String firstName)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].FirstName = firstName;
            db.WriteAllRecords(contacts, textFile);
        }

        // DELETE
        private static void RemoveUser()
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.RemoveAt(0);
            db.WriteAllRecords(contacts, textFile);
        }

        private static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            _config = builder.Build();
        }

    }
}