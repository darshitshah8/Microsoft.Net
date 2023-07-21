using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;

namespace TextFileUI
{
    class programm
    {
        private static IConfiguration _config;
        private static string textFile;
        public static TextFileDataAccess db = new TextFileDataAccess();
        public static void Main(string[] args)
        {

            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");
            ContactsModel user1 = new ContactsModel();
            user1.FirstName = "Darshit";
            user1.LastName = "Shah";
            user1.EmailAddresses.Add("ds@my.com");
            user1.EmailAddresses.Add("dns@my.com");
            user1.PhoneNumber.Add("0978634123");
            user1.PhoneNumber.Add("0972334123");
            
            ContactsModel user2 = new ContactsModel();
            user2.FirstName = "Tim";
            user2.LastName = "Corey";
            user2.EmailAddresses.Add("tc@my.com");
            user2.EmailAddresses.Add("tkc@my.com");
            user2.PhoneNumber.Add("0978632334");
            user2.PhoneNumber.Add("0978634234");


            //CreateContact(user1);
            //CreateContact(user2);
            //UpdateContectFirstName("Darshitt");
            //RemovePhoneNumberFromContact("0972334123");
            //RemoveUser();
            ReadAllContact();



            Console.WriteLine("Process Done");
        }
        //CRUD = CREATE , READ , UPDATE , DELETE

        // CREATE 
        private static void CreateContact(ContactsModel contact)
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
        private static void RemovePhoneNumberFromContact(string phoneNumber)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].PhoneNumber.Remove(phoneNumber);
            db.WriteAllRecords(contacts, textFile);
        }
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