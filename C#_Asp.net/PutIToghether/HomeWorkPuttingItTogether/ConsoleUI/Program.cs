using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;
/*
Capture the information about each guest (assumtion is at least one guest and unknown maximum)
Input for capture : FirstName ,LastName , message to the host
once done, loop through each guest and print their information
 */



namespace ConsoleUI
{
    public class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            GettingGuestInformation();
            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInformation);
            }
        }
        private static void GettingGuestInformation()
        {
            string isMoreGuest = "";
            do
            {
                GuestModel guest = new GuestModel();
                
                guest.FirstName = GettingInfoFromConsole("What is your first name: ");

                
                guest.LastName = GettingInfoFromConsole("What is your last name: ");

                
                guest.MessageToHost = GettingInfoFromConsole("What message you like to tell your host : ");

                
                isMoreGuest = GettingInfoFromConsole("Are most guest are coming ? (yes/no) : ");

                Console.Clear();

                guests.Add(guest);

            } while (isMoreGuest.ToLower() != "no");
        }
        private static string GettingInfoFromConsole(string message)
        {
            string output = "";
            Console.Write(message);
            output = Console.ReadLine();
            return output;
        }
    }


}
