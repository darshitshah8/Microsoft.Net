using EFConsoleUI.DataAccess;
using EFConsoleUI.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CreateDarshit();
            //CreateTim();
            //ReadAll();
            //UpdateFirstName(2,"Timati");
            //ReadAll();
            //RemoveUser(2);
            //RemovePhoneNumber(2, "555-1212");
            Console.WriteLine("Done Proccessing!");
            Console.ReadLine();
            
        }
        private static void CreateDarshit()
        {
            var c = new Contact
            {
                FirstName= "Darshit",
                LastName = "Shah"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "darshitshah@gmail.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "darshits@gmail.com" });

            c.PhoneNumbers.Add(new Phone { PhoneNumber = "9783428970" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "7892347891" });
                
            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }
        private static void CreateTim()
        {
            var c = new Contact
            {
                FirstName = "Tim",
                LastName = "Corey"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "timcorey@aol.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "timc@gmail.com" });

            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1214" });

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }
        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                var records = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
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
                var user = db.Contacts.Where(c => c.Id == id).First();
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }
        private static void UpdateFirstName(int id , string firstName)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                user.FirstName = firstName;
                db.SaveChanges();
            }
        }
        private static void RemovePhoneNumber(int id , string phoneNumber)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First();

                user.PhoneNumbers.RemoveAll(p => p.PhoneNumber == phoneNumber);
                    
                db.SaveChanges();
            }
        }
        private static void RemoveUser(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First();
                db.Contacts.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
