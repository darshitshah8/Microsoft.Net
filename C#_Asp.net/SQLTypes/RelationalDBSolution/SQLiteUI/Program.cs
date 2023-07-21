using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
namespace SQLiteUI;

class Program
{
    static void Main(string[] args) 
    {
        
        
        SqliteCrud sql = new SqliteCrud(GetConnectionString());

        CreateNewContact(sql);
        //ReadAllContact(sql);

        //UpdateContact(sql);

        //ReadAllContact(sql);
        //ReadContact(sql, 2);

        RemovePhoneNumberFromContact(sql, 1, 1);


    }
    private static void RemovePhoneNumberFromContact(SqliteCrud sql, int contactId, int phoneNumberId)
    {
        sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
    }
    private static void UpdateContact(SqliteCrud sql)
    {
        BasicContactModel contact = new BasicContactModel
        {
            Id = 2,
            FirstName = "Tim",
            LastName = "Last"
        };
        sql.UpdateContactName(contact);
    }
    private static void CreateNewContact(SqliteCrud sql)
    {
        FullContactModel user = new FullContactModel
        {
            BasicInfo = new BasicContactModel
            {
           
                FirstName = "Burhan",
                LastName = "Corey"
            }
        };

        user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "burhanCorey@her.com" });
       
        user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "8976897645" });

        sql.CreateContact(user);
    }
    private static void ReadAllContact(SqliteCrud sql)
    {
        var rows = sql.GetAllContacts();
        foreach (var row in rows)
        {
            Console.WriteLine($"{row.Id} : {row.FirstName} {row.LastName}");
        }
    }
    private static void ReadContact(SqliteCrud sql, int ContactId)
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