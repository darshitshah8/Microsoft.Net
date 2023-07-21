/* int range for
* unsigned 4 billion
* for signed +/- is 2 billion
* bit 0/1
* byte = 8 bit = 00000000
*/


int age = 0;
int count = 0;
string firstName = string.Empty;

Console.WriteLine("Enter Your Name:");
firstName = Console.ReadLine();

Console.WriteLine("Enter your birth Year: ");
age = Int32.Parse(Console.ReadLine());

for (int i = age; i < 2023; i++)
{
    count++;
}

Console.WriteLine($"hello {firstName}, you are {count} years old.");


