using StandardLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            CalculatorModel calculate = new CalculatorModel 
            {
                Num1 = num1,
                Num2 =num2
            };

            Console.WriteLine();

            Console.WriteLine($"{calculate.Num1} + {calculate.Num2} = {calculate.Num1+calculate.Num2}");
            Console.WriteLine();
        }
    }
}