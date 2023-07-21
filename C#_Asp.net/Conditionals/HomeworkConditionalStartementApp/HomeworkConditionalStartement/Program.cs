//HOMEWORK
//Create console application that asks the user for their name.
//welcome me (TIM) as professor or anyone else as student.
//Make sure that "TIM" also get called professor


// WITH USING IF ELSE 
Console.WriteLine("Enter your name");
string? name = Console.ReadLine();
if(name.ToLower() == "tim")
{
    Console.WriteLine($"Wellcome Professor{name}");
}
else
{
    Console.WriteLine("Welcome Student");
}

//WITH USE OF SWITCH
Console.WriteLine("Enter your name");
string? fName = Console.ReadLine();
switch (fName.ToLower())
{
    case "tim":
        Console.WriteLine($"Welcome {fName}");
        break;
    default:
        Console.WriteLine("Welcome Student");
        break;
}
