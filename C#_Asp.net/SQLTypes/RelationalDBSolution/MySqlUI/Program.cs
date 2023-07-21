using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace MySqlUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCrud sql = new MySqlCrud(GetConnectionString());

            //CreateNewContact(sql);
            //ReadAllContact(sql);
            //UpdateContact(sql);
            //RemovePhoneNumberFromContact(sql, 1, 1);
            ReadAllContact(sql);
            //ReadContact(sql, 2);

            
            Console.WriteLine("MYSql Done");

        }
        private static void RemovePhoneNumberFromContact(MySqlCrud sql, int contactId, int phoneNumberId)
        {
            sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
        }
        private static void UpdateContact(MySqlCrud sql)
        {
            BasicContactModel contact = new BasicContactModel
            {
                Id = 2,
                FirstName = "Tim",
                LastName = "Corey Second"
            };
            sql.UpdateContactName(contact);
        }
        private static void CreateNewContact(MySqlCrud sql)
        {
            FullContactModel user = new FullContactModel
            {
                BasicInfo = new BasicContactModel
                {

                    FirstName = "Charity",
                    LastName = "Corey"
                }
            };

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "charityCorey@her.com" });

            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "9876504321" });

            sql.CreateContact(user);
        }
        private static void ReadAllContact(MySqlCrud sql)
        {
            var rows = sql.GetAllContacts();
            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id} : {row.FirstName} {row.LastName}");
            }
        }
        private static void ReadContact(MySqlCrud sql, int ContactId)
        {
            var contact = sql.GetFullContactById(ContactId);

            Console.WriteLine($"{contact.BasicInfo.Id} : {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");

        }
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