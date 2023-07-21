// create a console application that asks user for name . welcome me (tim ) as professor
// or anyone else as student . Do this the until user type Exit

string name;
bool forExit = true;
do
{
    Console.Write("Enter Your Name or Exit for Exit:");
    name = Console.ReadLine();

    if (name.ToLower() == "exit")
    {
        forExit = false;
    }
    else if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Professor {name}.");
    }

    else
    {
        Console.WriteLine($"Welcome student {name} ");
    }

} while (forExit == true);