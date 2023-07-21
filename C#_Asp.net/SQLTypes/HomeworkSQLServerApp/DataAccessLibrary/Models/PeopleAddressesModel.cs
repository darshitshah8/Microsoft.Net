using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PeopleAddressesModel
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int AddressId { get; set; }
    }   
}
