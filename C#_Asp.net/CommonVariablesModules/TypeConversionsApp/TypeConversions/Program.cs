//Type Conversions of different variables

Console.WriteLine("Enter your age: ");
string? ageText = (Console.ReadLine());

bool isValidInt = int.TryParse(ageText, out int age); //convert string value in integer
Console.WriteLine($"This is valid {isValidInt}. The number was {age}");

