using DataAccessLibrary.Models;
using DataAccessLibrary;
using Microsoft.Extensions.Configuration;

namespace MySqlUI;

class Program
{
    static void Main(string[] args)
    {
        MySqlCrud sql = new MySqlCrud(GetConnectionString());

        //WORKING
        //CreateNewPeople(sql);
        //UpdatePeople(sql);
        ReadAllPeople(sql);
        //ReadPeople(sql, 2);

        RemoveAddressFromPeople(sql, 2, 4);
        Console.WriteLine("Done SQLite");
        Console.ReadLine();
    }
    private static void RemoveAddressFromPeople(MySqlCrud sql, int peopleId, int addressId)
    {
        sql.RemoveAddressFromPeople(peopleId, addressId);
    }
    private static void UpdatePeople(MySqlCrud sql)
    {
        PeopleModel people = new PeopleModel
        {
            Id = 2,
            FirstName = "Tim",
            LastName = "Gulati"
        };
        sql.UpdatePeopleName(people);
    }
    private static void CreateNewPeople(MySqlCrud sql)
    {
        FullPeopleModel user = new FullPeopleModel
        {
            PeopleInfo = new PeopleModel
            {
                FirstName = "Meet",
                LastName = "Mulati"
            }
        };

        user.Employers.Add(new EmployersModel { CompanyName = "Adani" });
        user.Employers.Add(new EmployersModel { CompanyName = "Coco" });
        user.Employers.Add(new EmployersModel { CompanyName = "Vadilal" });

        user.Addresses.Add(new AddressModel { StreetAddress = "GandhiDham", City = "Gandhinagar", State = "Gujrat", ZipCode = "124124" });


        sql.CreatePeople(user);
    }
    private static void ReadAllPeople(MySqlCrud sql)
    {
        var rows = sql.GetAllPeople();
        foreach (var row in rows)
        {
            Console.WriteLine($"{row.Id} : {row.FirstName} {row.LastName}");
        }
    }
    private static void ReadPeople(MySqlCrud sql, int PeopleId)
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
