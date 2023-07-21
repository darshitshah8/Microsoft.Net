using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class MySqlCrud
    {
        private readonly string _connectionString;
        private MySqlDataAccess db = new MySqlDataAccess();

        public MySqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }
        //CRUD
        public List<PeopleModel> GetAllPeople()
        {
            string sql = "select Id, FirstName , LastName from People";
            return db.LoadData<PeopleModel, dynamic>(sql, new { }, _connectionString);
        }

        public FullPeopleModel GetFullPeopleById(int id)
        {
            string sql = "select Id, FirstName , LastName from People where Id = @Id";
            FullPeopleModel output = new FullPeopleModel();

            output.PeopleInfo = db.LoadData<PeopleModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault();

            if (output.PeopleInfo == null)
            {
                //do something to tell the user that the record was not found               
                return null;
            }

            sql = @"select e.*
                    From Addresses e
                    inner join PeopleAddresses ce on ce.AddressId = e.Id
                    where ce.PeopleId = 1";

            output.Addresses = db.LoadData<AddressModel, dynamic>(sql, new { Id = id }, _connectionString);

            sql = @"select p.*
                    From Employers p
                    inner join PeopleAddresses cp on cp.AddressId = p.Id
                    where cp.PeopleId = 1";

            output.Employers = db.LoadData<EmployersModel, dynamic>(sql, new { Id = id }, _connectionString);

            return output;
        }

        public void CreatePeople(FullPeopleModel people)
        {
            // Save the basic people
            string sql = "insert into People (FirstName , LastName) values (@FirstName , @LastName);"; //sql = sqlstatement
            db.SaveData(sql,
                        new { people.PeopleInfo.FirstName, people.PeopleInfo.LastName },
                        _connectionString);
            // Get the ID number of the contact
            sql = "select Id from People where FirstName = @FirstName and LastName = @LastName;";

            int peopleId = db.LoadData<IdLookUpModel, dynamic>(sql,
                                                               new { people.PeopleInfo.FirstName, people.PeopleInfo.LastName },
                                                               _connectionString).First().Id;

            // Identify if the phone number exist
            foreach (var employer in people.Employers)
            {
                if (employer.Id == 0)
                {
                    sql = "insert into Employers (CompanyName) values (@CompanyName);";
                    db.SaveData(sql, new { employer.CompanyName }, _connectionString);

                    sql = "select Id from Employers where CompanyName = @CompanyName;";
                    employer.Id = db.LoadData<IdLookUpModel, dynamic>(sql, new { employer.CompanyName }, _connectionString).First().Id;
                }
                sql = "insert into PeopleEmployers(PeopleId,EmployerId) values (@PeopleId, @EmployerId);";

                db.SaveData(sql, new { PeopleId = peopleId, EmployerId = employer.Id }, _connectionString);
            }
            //for Addresses
            foreach (var address in people.Addresses)
            {
                if (address.Id == 0)
                {
                    sql = "insert into Addresses (StreetAddress,City,State,ZipCode) values (@StreetAddress,@City,@State,@ZipCode);";
                    db.SaveData(sql, new { address.StreetAddress, address.City, address.State, address.ZipCode }, _connectionString);

                    sql = "SELECT Id FROM Addresses WHERE StreetAddress = @StreetAddress AND City = @City AND State = @State AND ZipCode = @ZipCode;";
                    address.Id = db.LoadData<IdLookUpModel, dynamic>(sql, new { address.StreetAddress, address.City, address.State, address.ZipCode }, _connectionString).First().Id;
                }
                sql = "insert into PeopleAddresses(PeopleId,AddressId) values (@PeopleId, @AddressId);";

                db.SaveData(sql, new { PeopleId = peopleId, AddressId = address.Id }, _connectionString);
            }
        }

        public void UpdatePeopleName(PeopleModel people)
        {
            string sql = "update People set FirstName = @FirstName, LastName = @LastName where Id = @Id";
            db.SaveData(sql, people, _connectionString);
        }
        public void RemoveAddressFromPeople(int peopleId, int addressId)
        {
            string sql = "select Id, PeopleId,AddressId from PeopleAddresses where AddressId =@AddressId;";
            var links = db.LoadData<PeopleAddressesModel, dynamic>(sql, new { AddressId = addressId }, _connectionString);

            sql = "delete from PeopleAddresses where  PeopleId= @PeopleId and AddressId = @AddressId ";
            db.SaveData(sql, new { AddressId = addressId, PeopleId = peopleId }, _connectionString);

            if (links.Count == 1)
            {
                sql = "delete from Addresses where Id = @AddressId;";
                db.SaveData(sql, new { AddressId = addressId }, _connectionString);
            }


        }
    }
}
