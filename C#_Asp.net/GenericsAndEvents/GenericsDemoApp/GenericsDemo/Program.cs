using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = FizzBuzz("tests");
            //Console.WriteLine($"Test Result : {result}");

            //result = FizzBuzz(123);
            //Console.WriteLine($"Int result : {result}");

            //result = FizzBuzz(true);
            //Console.WriteLine($"Bool result : {result}");

            //result = FizzBuzz(new PersonModel { FirstName = "meet", LastName = "parmar" });
            //Console.Write($"Person Model : {result}");

            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "tim", HasError = true});

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName}{item.LastName} was rejected.");
            }    

            Console.ReadLine();
        }
    
        private static string FizzBuzz<T>(T item)
        {
            int intLength = item.ToString().Length;
            string output = " ";

            if (intLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (intLength % 5 == 0)
            {
                output += "Buzz";
            }
            return output;
        }
    }
}

