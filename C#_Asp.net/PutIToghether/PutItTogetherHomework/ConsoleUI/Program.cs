using GuestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleUI
{
    public class Program
    {
        private static  List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            AskForInput();
            PrintData();
            Console.ReadLine();
        }

        private static void AskForInput()
        {
            string isMoreGuest = "";
            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = ConsoleMessages("Enter your first name :");


                guest.LastName = ConsoleMessages("Enter your last name : ");


                guest.MessageToHost = ConsoleMessages("enter message for host : ");

                guests.Add(guest);
                isMoreGuest = ConsoleMessages("Is more guest coming? (yes/no) : ");
                Console.Clear();
            } while (isMoreGuest.ToLower() == "yes");
        }
        public static void PrintData()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GeuestInformation);
            }
        }
        private static string ConsoleMessages(string message)
        {
            string output = "";
            Console.WriteLine(message);
            output = Console.ReadLine();
            return output;
        }
    }
}
