using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassProperty
{
    public class Program
    {
        public static void Main(string[] args)
        {
                PersonModel address = new PersonModel();  //PesonModel is Constructor
                address.StreetAddress = "1600 Pennsylvania Avenue ";
                address.City = "Colambia";
                address.State = "Unitied State";
                address.ZipCode = "20500";
                Console.WriteLine(address.FullAddress);
                Console.ReadLine();

        }
    }
}
