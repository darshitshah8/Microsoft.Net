using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Runtime.Intrinsics.Arm;

namespace HomeWorkMongoUI
{
    public class Program
    {
        private static MongoDbDataAccess db;

        private static readonly string tableName = "People";
        public static void Main(string[] args)
        {
            db = new MongoDbDataAccess("PeopleMongoDb", GetConnectionString());


            PeopleModel user = new PeopleModel
            {
                FirstName = "Darshit",
                LastName = "Shah"
            };
            user.Addresses.Add(new AddressModel { Addresses = "shahdarshit@my.com" });
            user.Addresses.Add(new AddressModel { Addresses = "darshitshah@his.com" });

            user.Employers.Add(new EmployerModel { Employers = "Nasa" });
            user.Employers.Add(new EmployerModel { Employers = "Isro" });

            //CREATE
            //CreatePeople(user);

            //READ
            ReadAllPeople();
            //ReadAllpeopleById("03dab33e-f382-49d5-a5b1-79538e6b27c0"); //TIM COREY

            //UPDATE
            UpdateContectFirstName("Meet", "faa8eb1d-3b8c-4935-9497-166201633178");
            ReadAllPeople();

            //DELETE
            //RemovePhoneNumberFrompeople("9877844321", "03dab33e-f382-49d5-a5b1-79538e6b27c0");

            //RemoveUser("58914e2a-2bd5-43df-854a-c508a998d06c");
            //ReadAllPeople();
            Console.WriteLine("Done Proccessing MongoDb");
        }


        //CRUD = CREATE , READ , UPDATE , DELETE

        // CREATE 
        private static void CreatePeople(PeopleModel people)
        {
            //03dab33e-f382-49d5-a5b1-79538e6b27c0
            db.UpsertRecord(tableName, people.Id, people);
        }

        // READ
        private static void ReadAllPeopleById(string id)
        {
            Guid guid = new Guid(id);
            var people = db.LoadRecordById<PeopleModel>(tableName, guid);
            Console.WriteLine($"{people.Id} : {people.FirstName} {people.LastName}");
        }
        private static void ReadAllPeople()
        {
            var peoples = db.LoadRecords<PeopleModel>(tableName);
            foreach (var people in peoples)
            {
                Console.WriteLine($"{people.Id} : {people.FirstName} {people.LastName}");
            }
        }

        // UPDATE
        private static void UpdateContectFirstName(string firstName, string id)
        {
            Guid guid = new Guid(id);
            var people = db.LoadRecordById<PeopleModel>(tableName, guid);
            people.FirstName = firstName;
            db.UpsertRecord(tableName, guid, people);
        }

        // DELETE
        private static void RemoveEmployerFromPeople(string employer, string id)
        {
            Guid guid = new Guid(id);
            var people = db.LoadRecordById<PeopleModel>(tableName, guid);
            people.Employers = people.Employers.Where(x => x.Employers != employer).ToList();

            db.UpsertRecord(tableName, people.Id, people);
        }
        private static void RemoveUser(string id)
        {
            Guid guid = new Guid(id);
            db.DeleteRecord<PeopleModel>(tableName, guid);
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