
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {

        private MongoDbDataAccess db;
        private readonly string tableName = "Contacts";
        private readonly IConfiguration _config;

        public ContactsController(IConfiguration config)
        {
            _config = config;
            db = new MongoDbDataAccess("MongoDbContactDb", _config.GetConnectionString("Default"));
        }

        [HttpGet]
        public List<ContactModel> GetAll() 
        {
            return db.LoadRecords<ContactModel>(tableName);
        }
        [HttpPost]
        public void InsertRecord(ContactModel contact)
        {
            db.UpsertRecord(tableName,contact.Id,contact);
        }
    }
}
