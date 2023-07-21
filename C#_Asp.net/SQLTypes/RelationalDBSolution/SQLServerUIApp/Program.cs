using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Dynamic;
using System.IO;

namespace SQLServerUIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCrud sql = new SqlCrud(GetConnectionString());
            //ReadAllContact(sql);
            //CreateNewContact(sql);
            //UpdateContact(sql);
            //ReadContact(sql, 2);
            //RemovePhoneNumberFromContact(sql, 1005, 1009);
            Console.WriteLine("Done From SQL Server");
            Console.ReadLine();
        }
        private static void RemovePhoneNumberFromContact(SqlCrud sql,int contactId,int phoneNumberId) 
        { 
            sql.RemovePhoneNumberFromContact(contactId,phoneNumberId);
        }
        private static void UpdateContact(SqlCrud sql)
        {
            BasicContactModel contact = new BasicContactModel
            {
                Id = 2,
                FirstName = "Name2",
                LastName = "LastName2"
            };
            sql.UpdateContactName(contact);
        }
        private static void CreateNewContact(SqlCrud sql) 
        {     
            FullContactModel user = new FullContactModel
            {
                BasicInfo = new BasicContactModel
                {
                    FirstName = "Tim",
                    LastName = "Corey"
                }
            };

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "darshit@ad.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "none@gmail.com" });

            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "987654321" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "9807654321" });

            sql.CreateContact(user);
        }
        private static void ReadAllContact(SqlCrud sql)
        {
            var rows = sql.GetAllContacts();
            foreach (var row in rows) 
            {
                Console.WriteLine($"{row.Id} : {row.FirstName} {row.LastName}");
            }
        }
        private static void ReadContact(SqlCrud sql , int ContactId)
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
