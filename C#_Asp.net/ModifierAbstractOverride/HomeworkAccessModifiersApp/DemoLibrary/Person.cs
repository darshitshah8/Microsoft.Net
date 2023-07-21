using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Person
    {
        internal string FirstName { get; set; }
        private string LastName { get; set; }  
        
        public string Address()
        {
            return "Address";
        }
        public string GetAllData()
        {
            return GetAllData();
        }
        public string PrintFirstName() 
        {
            return FirstName = "Darshit";
        }

    }

}
