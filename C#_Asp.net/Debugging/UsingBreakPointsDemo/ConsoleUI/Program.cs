using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i  < 20; i ++)
            {
                Console.WriteLine($" the value of i is {i}");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"the value of j is {j}");
                    
                }
            }
            Console.ReadLine();
        }
    }
}



//NOTE: PRO TIP:- A bug is an opportunity not something to be avoided 
//Using breakPoints to find the bug/error in programm