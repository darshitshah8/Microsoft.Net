using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person();
             person.SavePerson();                       

            Console.ReadLine();
        }
        public class ModifiedAccessData : DataAccess
        {
            public void GetInsecureInformation()
            {
                GetConnectionString();                    
            }
        }
        public class CEO : Manager
        {
            public  void GetConnectionInfo()
            {
                 ModifiedAccessData data = new ModifiedAccessData();
                data.GetInsecureInformation();  
                formerLastName = "test";
            }
        }
    }
}
