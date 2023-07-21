string name;
bool noMore = true;
List<string> firstNames = new List<string>();
do
{
    Console.WriteLine("Enter Your Name");
    name = Console.ReadLine();
    if (name.ToLower() == "exit")
    {
        noMore = false;
        Console.WriteLine(" ");
    }
    else
    {
        
        firstNames.Add(name);
        Console.WriteLine(" ");
    }
} while (noMore == true);
foreach (string firstName in firstNames)
{
    Console.WriteLine($"Hello {firstName}");
}

