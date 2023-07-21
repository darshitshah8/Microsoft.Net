bool isValidInput = true;
List<string> student = new List<string>();
do
{
    Console.WriteLine("Enter the Name");
    string name = Console.ReadLine();
    if (name.ToLower() == "exit")
    {
        isValidInput = false;
    }
    else if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Hello Professor {name}");
    }
    else
    {
        student.Add(name);
        Console.WriteLine($"Hello Mr. {name}");
    }
} while (isValidInput == true);

Console.WriteLine($" there are {student.Count} students");
Console.Write("Hello ");
for (int i = 0; i < student.Count; i++)
{
    Console.Write($" {student[i]} ");
}