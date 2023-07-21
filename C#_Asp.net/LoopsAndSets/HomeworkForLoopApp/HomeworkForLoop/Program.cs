Console.WriteLine("Enter the comma separated value which include ',' ");
string names = Console.ReadLine();
List<string> name = names.Split(',').ToList();   


for (int i = 0; i < name.Count; i++)
{
    Console.WriteLine($"Hello {name[i]}");
}