string data = "tim,sue,bob,jane";
List<string> firstNames = data.Split(',').ToList();


foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}
    //Same Output as string
//foreach (var firstName in firstNames)
//{
//    Console.WriteLine(firstName);
//}