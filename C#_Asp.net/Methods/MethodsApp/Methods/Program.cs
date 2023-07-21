using Methods;


ConsoleMessages.SayHello();
ConsoleMessages.AskName();
string username = ConsoleMessages.GetUserName();
//------------------------------------------------------------------

//---------------------------------------------------------------------

//USE PARAMETERS
Console.WriteLine("Enter your name");
string name = Console.ReadLine();
ConsoleMessages.SayHelloByParameter(name);

//CALLING METHODS - RETURNING VALUE : =

//INPUT FROM USER
Console.WriteLine("Enter the number for mathematics");
var x = Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());
double result = MathsShortCut.Add(x, y);
Console.WriteLine($"the addition of {x} and {y} is {result} ");
MathsShortCut.Div(x, y);
MathsShortCut.Mul(x, y);
MathsShortCut.Sub(x, y);


//WITH ARRAY 
double[] vals = new double[] { 2, 3, 4, 5, 6, 7 };
MathsShortCut.AddAll(vals);

double[] valc = new double[] { 1, 29, 32, 43, 45, 65, 76 };
MathsShortCut.AddAll(valc);
//---------------------------------------------------------------------------------
//TUPLES
var fullName = ConsoleMessages.GetFullName();
Console.WriteLine($"First Name is {fullName.Item1}");
Console.WriteLine($"Last Name is {fullName.Item2}");

//OR
//USE THIS 
(string firstName, string lastName) = ConsoleMessages.GetFullName();
Console.WriteLine($"First Name is {firstName}");
Console.WriteLine($"Last Name is {lastName}");

//OR
// DISCARD CHARACTER (" _ ")
//(string firstName, _) = ConsoleMessages.GetFullName();  //Only return firstName 
//Console.WriteLine($"First Name is {firstName}"); 
// //Console.WriteLine($"Last Name is {lastName}");
//OR

//(string firstName, string lastName) fName= ConsoleMessages.GetFullName();
//Console.WriteLine($"First Name is {fName.firstName}");
//Console.WriteLine($"Last Name is {fName.lastName}");

//OR

//var (firstName,lastName) = ConsoleMessages.GetFullName();
//Console.WriteLine($"First Name is {firstName}");
//Console.WriteLine($"Last Name is {lastName}");

//OR

//(string , string) fullName = ConsoleMessages.GetFullName();
//Console.WriteLine($"First Name is {fullName.Item1}");
//Console.WriteLine($"Last Name is {fullName.Item2}");

//=================================================================================
//PRACTICE
//for (int i = 0; i < 10; i++)
//{
//    SayHello();
//}

//Console.WriteLine("Enter your name");
//ConsoleMessages.AskName();
//ConsoleMessages.AskAge();



//NOTES:
//1.
//using static System.Console;
//Write("This line is print without Console.Write");
//WriteLine();
//WriteLine("This Line is print without console.writeline");
//2.
// DRY -DON'T REPEAT YOURSELF
// SOLID - SRP = SINGLE RESPONSIBILITY PRINCIPLE