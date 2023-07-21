using System.Runtime.InteropServices;

Console.WriteLine("Welcome to Switch Case demo");




//PRACTICE
Console.WriteLine("Enter the number of the day");
string? day = Console.ReadLine();
int dayNum = int.Parse(day);
switch (dayNum)
{
    case 1:
        Console.WriteLine("It's Monday");
        break;
    case 2:
        Console.WriteLine("It's Tuesday");
        break;
    case 3:
        Console.WriteLine("It's Wednesday");
        break;
    case 4:
        Console.WriteLine("It's Thusday");
        break;
    case 5:
        Console.WriteLine("It's Friday");
        break;
    case 6:
        Console.WriteLine("It's Saturday");
        break;
    case 7:
        Console.WriteLine("It's Sunday");
        break;
    default:
        Console.WriteLine("Invalid Input, Enter valid inut");
        break;
}

//MODULE

string name = "DarshitShah  ";
int age = 22;

switch (age)
{
    case >= 0 and <= 18:
        Console.WriteLine("You are child");
        break;
    case > 18 and <= 25:
        Console.WriteLine("You are adult");
        break;
    case > 25 and <= 60:
        Console.WriteLine("You are elder");
        break;
    case > 60:
        Console.WriteLine("You are old man");
        break;
    default:
        Console.WriteLine("invalid");
        break;
}

//WITH NAME
switch (name.ToLower())
{
    //case "shah":
    case "darshit" or "darshitshah":
        Console.WriteLine("Welcome Darshit");
    break;
    case "Hp":
        Console.WriteLine("Hello");
    break;
    default:
        Console.WriteLine("Who are you");
    break;
}

