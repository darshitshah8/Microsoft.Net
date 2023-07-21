using HomeworkEF.DataAccess;
using HomeworkEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Numerics;

namespace HomeworkEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CreateDarshit();
            //CreateTim();
            ReadAll();
            Console.WriteLine();
            UpdateFirstName(6, "Timati");
            //ReadAll();
            //RemoveUser(3);
            //RemoveUser(4);
            Console.WriteLine();
            ReadAll();
            //RemovePhoneNumber(2, "555-1212");

            Console.WriteLine("Done Processing!");
            Console.ReadLine();
        }
        private static void CreateDarshit()
        {
            var c = new Person
            {
                FirstName = "Darshit",
                LastName = "Shah"
            };
            c.Addresses.Add(new Address { City = "Rajkot" });
            c.Addresses.Add(new Address { City = "Veraval" });

            c.Employers.Add(new Employer { CompanyNames = "Tata" });
            c.Employers.Add(new Employer { CompanyNames = "Apple" });

            using (var db = new ContactContext())
            {
                db.People.Add(c);
                db.SaveChanges();
            }
        }
        private static void CreateTim()
        {
            var c = new Person
            {
                FirstName = "Tim",
                LastName = "Corey"
            };
            c.Addresses.Add(new Address { City = "US" });
            c.Addresses.Add(new Address { City = "North US" });

            c.Employers.Add(new Employer { CompanyNames = "Tim" });
            c.Employers.Add(new Employer { CompanyNames = "Corey" });

            using (var db = new ContactContext())
            {
                db.People.Add(c);
                db.SaveChanges();
            }
        }
        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                var records = db.People
                    .Include(e => e.Addresses)
                    .Include(p => p.Employers)
                    .ToList();

                foreach (var c in records)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName}");
                }
            }
        }
        private static void ReadById(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.People.Where(c => c.Id == id).First();
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }
        private static void UpdateFirstName(int id, string firstName)
        {
            using (var db = new ContactContext())
            {
                var user = db.People.Where(c => c.Id == id).First();

                user.FirstName = firstName;
                db.SaveChanges();
            }
        }
        private static void RemovePhoneNumber(int id, string companyName)
        {
            using (var db = new ContactContext())
            {
                var user = db.People
                    .Include(p => p.Employers)
                    .Where(c => c.Id == id).First();

                user.Employers.RemoveAll(p => p.CompanyNames == companyName);

                db.SaveChanges();
            }
        }
        private static void RemoveUser(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.People
                    .Include(e => e.Addresses)
                    .Include(p => p.Employers)
                    .Where(c => c.Id == id).First();
                db.People.Remove(user);
                db.SaveChanges();
            }
        }

    }
}
