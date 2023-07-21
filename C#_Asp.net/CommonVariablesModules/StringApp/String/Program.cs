string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;
string fileName = string.Empty;

firstName = "tim";
lastName = "hopper";
fileName = "String";
filePath = @"C\main\StringApp"; // Use of @

Console.WriteLine($@"Path for a {fileName} is as C\Main\StringVariables");

Console.WriteLine($" full name is{firstName} {lastName}");
Console.WriteLine($"file path is {filePath}");
