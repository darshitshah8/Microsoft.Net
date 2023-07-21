using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsLeagueModule indoor = new SportsLeagueModule("Chess", 2);
            SportsLeagueModule outdoor = new SportsLeagueModule("Vollyball", 6);


            indoor.EnrollmentFull += CollageClass_EnrollmentFull;

            indoor.RegisterStudents("joe").PrintToConsole();
            indoor.RegisterStudents("kai").PrintToConsole();
            indoor.RegisterStudents("Zark").PrintToConsole();
            indoor.RegisterStudents("bob").PrintToConsole();
            indoor.RegisterStudents("Tony").PrintToConsole();
            Console.WriteLine();

            outdoor.EnrollmentFull += CollageClass_EnrollmentFull;

            outdoor.RegisterStudents("Zark").PrintToConsole();
            outdoor.RegisterStudents("James").PrintToConsole();
            outdoor.RegisterStudents("Gim").PrintToConsole();
            outdoor.RegisterStudents("Joe").PrintToConsole();
            outdoor.RegisterStudents("Mark").PrintToConsole();
            outdoor.RegisterStudents("Drek").PrintToConsole();
            outdoor.RegisterStudents("burhan").PrintToConsole();

            Console.ReadLine();
        }

        private static void CollageClass_EnrollmentFull(object sender, string e)
        {
            SportsLeagueModule model = (SportsLeagueModule)sender;

            Console.WriteLine();
            Console.WriteLine($"{model.GameName} : Full");
            Console.WriteLine();
        }        
    }
}
