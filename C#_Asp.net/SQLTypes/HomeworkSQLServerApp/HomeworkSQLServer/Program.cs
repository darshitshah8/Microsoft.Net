using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;



namespace SQLServerUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlCrud sql = new SqlCrud(GetConnectionString());

            //CreateNewContact(sql);
            //UpdateContact(sql);
            CreateNewPeople(sql);
            //RemovePhoneNumberFromContact(sql, 1005, 1009);
            Console.WriteLine("Done Dona Done");
            Console.ReadLine();
        }
        private static void RemovePhoneNumberFromContact(SqlCrud sql, int peopleId, int employersId)
        {
            sql.RemoveCompanyFromPeople(peopleId, employersId);
        }
        private static void UpdateContact(SqlCrud sql)
        {
            PeopleModel people = new PeopleModel
            {
                Id = 2,
                FirstName = "Name2",
                LastName = "LastName2"
            };
            sql.UpdatePeopleName(people);
        }
        private static void CreateNewPeople(SqlCrud sql)
        {
            FullPeopleModel user = new FullPeopleModel
            {
                PeopleInfo = new PeopleModel
                {
                    FirstName = "Tim",
                    LastName = "Corey"
                }
            };

            user.Employers.Add(new EmployersModel { CompanyName = "TCS" });
            user.Employers.Add(new EmployersModel { CompanyName = "AMUL" });
            user.Employers.Add(new EmployersModel { CompanyName = "Reliece" });

            user.Addresses.Add(new AddressModel { StreetAddress = "GandhiGram" , City ="Rajkot" ,State="Gujrat",ZipCode = "360008"});
            user.Addresses.Add(new AddressModel { StreetAddress = "Punit Nagar", City = "Rajkot", State = "Gujrat", ZipCode = "360004" });
            user.Addresses.Add(new AddressModel { StreetAddress = "Mirchi pol", City = "Ahemdabad", State = "Gujrat", ZipCode = "AHMD23" });

            sql.CreatePeople(user);
        }
        private static void ReadAllPeople(SqlCrud sql)
        {
            var rows = sql.GetAllPeople();
            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id} : {row.FirstName} {row.LastName}");
            }
        }
        private static void ReadPeople(SqlCrud sql, int PeopleId)
        {
            var people = sql.GetFullPeopleById(PeopleId);

            Console.WriteLine($"{people.PeopleInfo.Id} : {people.PeopleInfo.FirstName} {people.PeopleInfo.LastName}");

        }
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            var config = builder.Build();
            //var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);
            return output;


        }
    }
}