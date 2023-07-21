using System.Runtime.InteropServices;

Console.Write("What is your first Name : ");
string firstName = Console.ReadLine();
Console.Write("What is your last Name : ");
string lastName = Console.ReadLine();

// USE OF && (AND) 
if (firstName.ToLower() == "darshit" && lastName.ToLower() == "shah")
{
    Console.WriteLine($"Hello {firstName} {lastName}, Welcome back to application");
}
// USE OF  || (OR)
else if (firstName.ToLower() == "darshit" || lastName.ToLower() == "shah")
{
    Console.WriteLine($"you have great part in your name");
}
else
{
    Console.WriteLine($"Hello {firstName} {lastName}");
}
//else if(firstName.ToLower() =="darshit")
//{
//    Console.WriteLine($"Hello {firstName} {lastName}, Welcome to the application");
//}else if(lastName.ToLower() =="coder")
//{
//    Console.WriteLine($"Hello {firstName} {lastName}" );
//}

//if(firstName.ToLower() == "darshit") 
//{
//    Console.WriteLine("You have great name");
//}

//if(lastName.ToLower() == "shah") 
//{
//    Console.WriteLine("You have Gretest Surname");
//}
//else
//{
//    Console.WriteLine("You have still good Full Name");
//}



//Conditions Operators  
// == , < , > , <= , >= ,!= (! = bang character) , . . . .
Console.Write("Enter Your age:");
String? ageCount = Console.ReadLine();
int age = int.Parse(ageCount);
if (age >= 18 && age <= 80)
{
    Console.WriteLine($"You are {age} years old and you are allow to drive car");
}
else if (age < 18)
{
    Console.WriteLine($"You are {age} years old and you are not allow to drive car ");
}
else
{
    Console.WriteLine($"You are {age} years old and you are to old to drive car");
}



// PRACICED
//Console.WriteLine("Enter Your Name");
//string? name = Console.ReadLine();
//Console.WriteLine("Enter Your birth Year");
//string? birthYear = Console.ReadLine();
//int bYear =  int.Parse(birthYear);
//if (bYear >= 2004)
//{
//    Console.WriteLine($"Sorry {name}, you are not allow to get licence ");
//}
//else
//{
//    Console.WriteLine($"Hi {name} , you are allow to get licence");
//}