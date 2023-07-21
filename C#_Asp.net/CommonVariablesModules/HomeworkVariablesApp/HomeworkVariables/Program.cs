//create a console app that has variables to hold a person's name,age,if they are alive and their phone number.You do not need to capture there values from the user.

string name = string.Empty;
int age = 0;
double phoneNumber = 0;
string userinput;

Console.WriteLine("Are you alive? Answer  in  yes/no");
userinput = Console.ReadLine();
if (userinput.ToLower() == "yes")
{
    Console.WriteLine("Enter your Name:");
    name = Console.ReadLine();

    Console.WriteLine("Enter your age:");
    age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your Phone Number:");
    phoneNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Hello {name}, you are {age} years old and your phone Number is {phoneNumber}");
}

else
{
    Console.WriteLine("Your data is not availabe");
}