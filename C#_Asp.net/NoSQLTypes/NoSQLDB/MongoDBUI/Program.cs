using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Runtime.Intrinsics.Arm;

namespace MongoDBUI
{
    class Program
    {
        private static MongoDbDataAccess db;
        private static readonly string tableName = "Contacts";
        public static void Main(string[] args)
        {
            db = new MongoDbDataAccess("MongoDbContactDb",GetConnectionString());


            ContactModel user = new ContactModel
            {
                FirstName = "Meetansha",
                LastName = "Parmar"
            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "meeetparmar@her.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "meet@this.com" });

            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "9877811321" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "9876500322" });

            //CreateContact(user);
            //ReadAllContact();
            //6fe32064 - 6b30 - 46b2 - b9a5 - 30230cd790b0 Darshit Shah
            //ReadAllContactById("03dab33e-f382-49d5-a5b1-79538e6b27c0"); //TIM COREY
            //UpdateContectFirstName("Morey", "03dab33e-f382-49d5-a5b1-79538e6b27c0");
            //RemovePhoneNumberFromContact("9877844321", "03dab33e-f382-49d5-a5b1-79538e6b27c0");
            RemoveUser("03dab33e-f382-49d5-a5b1-79538e6b27c0");
            ReadAllContact();
            Console.WriteLine("Done Proccessing MongoDb");
        }


        //CRUD = CREATE , READ , UPDATE , DELETE

        // CREATE 
        private static void CreateContact(ContactModel contact)
        {
            //03dab33e-f382-49d5-a5b1-79538e6b27c0
            db.UpsertRecord(tableName, contact.Id, contact);
        }       

        // READ
        private static void ReadAllContactById(string id) 
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName , guid);
            Console.WriteLine($"{contact.Id} : {contact.FirstName} {contact.LastName}");
        }
        private static void ReadAllContact()
        {
            var contacts = db.LoadRecords<ContactModel>(tableName);
            foreach (var contact in contacts) 
            {
                Console.WriteLine($"{contact.Id} : {contact.FirstName} {contact.LastName}");
            }
        }

        // UPDATE
        private static void UpdateContectFirstName(string firstName , string id) 
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);
            contact.FirstName = firstName;
            db.UpsertRecord(tableName, guid, contact);      
        }

        // DELETE
        private static void RemovePhoneNumberFromContact(string phoneNumber,string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);
            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            db.UpsertRecord(tableName, contact.Id, contact);
        }   
        private static void RemoveUser(string id)
        {
            Guid guid = new Guid(id);
            db.DeleteRecord<ContactModel>(tableName, guid); 
        }

        //CONNECTION STRING CONNECT DATA
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            var config = builder.Build();
            output = config.GetConnectionString(connectionStringName);
            return output;
        }

    }
}