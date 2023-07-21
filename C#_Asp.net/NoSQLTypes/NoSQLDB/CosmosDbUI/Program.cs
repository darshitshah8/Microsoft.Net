using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace CosmosDbUI
{
    class Programm
    {
        private static CosmosDbDataAccess db;

        public static void Main(string[] args)
        {
            var c = GetCosmosInfo();
            db = new CosmosDbDataAccess(c.endpointUrl,c.primaryKey,c.databaseName,c.containerName);

            Console.WriteLine("Done Proccessing MongoDb");
        }


        //CRUD = CREATE , READ , UPDATE , DELETE

        // CREATE   
        private static void CreateContact(ContactModel contact)
        {
            
        }

        // READ
        private static void ReadAllContactById(string id)
        {
            
        }
        private static void ReadAllContact()
        {
            
        }

        // UPDATE
        private static void UpdateContectFirstName(string firstName, string id)
        {
            
        }

        // DELETE
        private static void RemovePhoneNumberFromContact(string phoneNumber, string id)
        {
            
        }
        private static void RemoveUser(string id)
        {
            
        }

        //CONNECTION STRING CONNECT DATA
        private static (string endpointUrl, string primaryKey, string databaseName, string containerName) GetCosmosInfo(string connectionStringName = "Default")
        {
            (string endpointUrl, string primaryKey, string databaseName, string containerName) output;

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            var config = builder.Build();
            output.endpointUrl = config.GetValue<string>("CosmosDB:EndpointsUrl");
            output.primaryKey = config.GetValue<string>("CosmosDB:primaryKey");
            output.databaseName = config.GetValue<string>("CosmosDB:DatabaseName");
            output.containerName = config.GetValue<string>("CosmosDB:ContainerName");
        
            return output;
        }
    }
}