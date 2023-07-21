//for (int i = 0; i < 15; i++)
//{
//    Console.WriteLine($"Roll Number {i}");
//}



string data = "pole,bane,jane";
List<string> firstName = data.Split(',').ToList();

for (int i = 0; i < firstName.Count; i++)
{
    Console.WriteLine($"Id : {i} Name: {firstName[i]}");

}

List<decimal> decimals = new();
decimals.Add(12.43M);
decimals.Add(23.453M);
decimals.Add(34.546M);
decimals.Add(43.456M);
decimals.Add(56.453M);
decimal total = 0;

for (int i = 0; i < decimals.Count; i++)
{
    total += decimals[i];
}

Console.WriteLine($"Tota of decimals is {total} ");