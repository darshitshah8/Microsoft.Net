using LinqUI.Models;
using System;
using System.Linq;

namespace LinqUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqTest();
            //LambadaTest();
            Console.WriteLine("Done!");

            Console.ReadLine();
        }
        private static void LinqTest()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            //var results = (from c in contacts
            //               where c.Addresses.Count > 1
            //               select c); 

            //var results = (from c in contacts
            //               join a in addresses
            //               on c.Id equals a.ContactId
            //               select new { c.FirstName , c.LastName , a.City , a.State});
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} from {item.City}, {item.State}");
            //}

            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName , Address = addresses.Where(x => x.ContactId == c.Id) });
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Address.Count()}");
            //}

            var results = (from c in contacts
                           select new { c.FirstName, c.LastName, Address = addresses.Where(a => c.Addresses.Contains(a.Id)) });
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Address.Count()}");
            }
        }
        private static void LambdasTest()
        {
            var data = SampleData.GetContactData();

            //var result = data.Where(x => x.Addresses.Count > 1);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FirstName}{item.LastName}");
            //}

            //var result = data.Select(x => x.FirstName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = data.Take(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FirstName}{item.LastName}");
            //}

            //var result = data.Skip(1).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FirstName}{item.LastName}");
            //}

            //var result = data.OrderBy(x => x.LastName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var result = data.OrderByDescending(x => x.LastName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}


        }

    }
}











//private static bool RunMe(ContactModel x)
//{
//    return x.Addresses.Count > 1;
//}