using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOverload
{
     class Program
    {   
        static void Main(string[] args)
        {
            var employee = new EmployeeModule("joseph", "marko");

            employee.GenerateUserName();
            Console.WriteLine(employee.UserName);

            employee.GenerateUserName("darshit","shah");
            Console.WriteLine(employee.UserName);

            employee.GenerateUserName(21);
            Console.WriteLine(employee.UserName);

                    
            Console.ReadLine();         
        }
    }
    public class EmployeeModule
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public EmployeeModule()
        {
            
        }
        public EmployeeModule(string firstName, string LastName)
        {
            FirstName = firstName;
            LastName = LastName;
        }
        public EmployeeModule(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateUserName()
        {
            UserName = $"{FirstName}{LastName}";    
        }
        public void GenerateUserName(string FirstName , String LastName)
        {
            UserName = $"{FirstName}{LastName}";
        }
        public void GenerateUserName(int num) 
        {
            UserName = $"{FirstName}{LastName}{num}";
        }
    }
}
