//for a decimal number we can use this only when we need a massive data like in a money of bank account and space measurement.
// it takes a large amount of space in your database so it used only when it requried so we can you a double instead of a decimal.

decimal idNumber = 0M;

Console.WriteLine("Enter your 12 digit id number to continue:");
//int num = Convert.ToInt32(Console.ReadLine()); // it return error 
//Console.WriteLine(num);
idNumber = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Your id number is {idNumber}");
Console.WriteLine("Welcome");


decimal num1 = 12234.234M;
decimal num2 = 22342.4235M;
decimal sum = num1 + num2;
Console.WriteLine($"Sum of {num1} and {num2} is {sum}");