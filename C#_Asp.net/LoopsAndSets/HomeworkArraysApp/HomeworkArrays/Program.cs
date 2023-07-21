string[] name = new string[] {"John","Tom","Jerry"};
Console.WriteLine("Enter the index number to get name");
string? input = Console.ReadLine();
bool isValidNum = int.TryParse(input, out int num);
if (isValidNum == false || num>name.Length-1)
{
    Console.WriteLine("Enter valid input");
}
else
{
    Console.WriteLine($"{name[num]}");
}
