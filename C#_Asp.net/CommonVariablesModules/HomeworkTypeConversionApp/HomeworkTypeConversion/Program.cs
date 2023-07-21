/*capture user's age from the console and
then identify how they will be in 25 years,
as well as how old there were 25 years ago.
print that information to the console in a natural language.*/

int birthYear = 0;
int age = 0;

Console.WriteLine("Enter your birth Year: ");
birthYear = Convert.ToInt32(Console.ReadLine());

for (int i = birthYear; i < 2023; i++)
{
    age++;
}
Console.WriteLine($"Your Current Age is {age}");

int afterage = age + 25;
Console.WriteLine($"Your age after 25 Years is {afterage}");

int beforeage = age - 25;
Console.WriteLine($"Your age before 25 Years in {beforeage}");

