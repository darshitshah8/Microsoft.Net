using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAccessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person data = new Person();
            

            Manager dataManager = new Manager();
            string name = dataManager.GetFirstName();
            Console.WriteLine(name);

            GetSecretCode getCode = new GetSecretCode();
            string code = getCode.GetCode();
            Console.WriteLine(code);

            Console.ReadLine();
        }
    }
}
