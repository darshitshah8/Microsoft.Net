using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class FullPeopleModel
    {
        public PeopleModel PeopleInfo { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
        public List<EmployersModel> Employers { get; set; } = new List<EmployersModel>();

    }
}
