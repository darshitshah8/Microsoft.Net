Console.WriteLine("Enter Your Name");
string? name = Console.ReadLine();
Console.WriteLine("Enter your age");
string? age = Console.ReadLine();


if (int.TryParse(age, out int ageNum))
{
    if (name.ToLower() == "bob" || name.ToLower() == "Sue")
    {
        Console.WriteLine($"Welcome Professor {name}");
    }
    else
    {
        Console.WriteLine($"Welcome {name}, you are Student");
    }
    if (ageNum >= 21)
    {
        Console.WriteLine("You are allow to taking lecture");
    }
    else
    {
        Console.WriteLine($"{name} need to wait for {21 - ageNum} years for take lecture");
    }
    Console.ReadLine();
}
else
{
    Console.WriteLine("Enter a valid age");
}
