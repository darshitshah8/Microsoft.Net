using System;
using System.Linq;

namespace HomeworkLinqAndLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinqTest();
            LambdasTest();
            Console.WriteLine("Done!");

            Console.ReadLine();
        }
        private static void LinqTest()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            var results = (from c in contacts
                           join a in addresses
                           on c.Id equals a.ContactId
                           select new { c.FirstName, c.LastName, a.City, a.State });
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} from {item.City}, {item.State}");
            }


}
        private static void LambdasTest()
        {
            var data = SampleData.GetContactData();

            var result = data.Where(x => x.Addresses.Count > 1);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}