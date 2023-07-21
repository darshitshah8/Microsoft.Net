using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MiniProjectGuestBook
{
    public class ConsoleMessages
    {
        //Welcome to user in the application
        public static void WelocomeToApp()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Welcome to guest book app");
            Console.WriteLine("_________________________");
        }
        //Ask for their names and store 
        public static string AskUserName()
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, Welcome to the party");
            return name;

        }
        //Ask guest , how many of them
        public static int AskForTotalMembers()
        {
            bool isValidNumber;
            int partyMembers;
            do
            {
            Console.Write("How many of you in the party : ");
            string memberText = Console.ReadLine();
            isValidNumber = int.TryParse(memberText, out partyMembers);

            } while (isValidNumber == false);
            if (!isValidNumber) 
            {
                Console.WriteLine("Sorry invalid input , please try again");
            }
            return partyMembers;

        }
        //Ask that, there are any more/other guest
        public static bool isMoreGuestThere()
        {
            Console.WriteLine("are there more guests ? (yes/no)");
            string isMoreGuest = Console.ReadLine();
            bool output = (isMoreGuest.ToLower() == "yes");
            return output;
        }
        //Contains guest names and number of the toal guest
        public static (List<string> totalGuest , int totalMembers) AllGuest() 
        {
            int totalMembers = 0;
            string isMoreGuest;
            ConsoleMessages.WelocomeToApp();   
            List<string> totalGuest = new List<string>();
            do
            {
                totalGuest.Add(AskUserName());
                totalMembers += AskForTotalMembers(); //AskForTheTotalMember which return total member of one party          
            } while (isMoreGuestThere());
            return (totalGuest, totalMembers);
        }
        //Return the total number of the guest names in party
        public static void DisplayTotalGuestName(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.Write($"{guest}, ");
            }
        }
        //Return total number of guest in the party
        public static void totalNumberOfGuest(int totalGuest)
        {
            Console.WriteLine("Thank you for coming in party.");
            Console.WriteLine($"There are total {totalGuest} guest members in our party.");
            Console.WriteLine("Enjoy your party, Have a nice evening");
        }

    }
}
