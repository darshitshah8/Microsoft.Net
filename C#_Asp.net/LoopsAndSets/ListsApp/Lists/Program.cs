//// string[] firstName = new string[];
////STRING
List<string> firstName = new List<string>();
firstName.Add("Tim");
firstName.Add("Tom");
firstName.Add("Teem");
firstName.Add("Tomy");
firstName.Add("Timithy");
Console.WriteLine(firstName[0]);
Console.WriteLine(firstName[firstName.Count - 1]);
Console.WriteLine(firstName.Count);

////NUMBER
List<int> num = new List<int>();
num.Add(1);
num.Add(2);
num.Add(3);
Console.WriteLine(num[0]);

//// List<T> generic
string data = "cruse, mikas,lokeas";
List<string> lName = data.Split(',').ToList(); //Convert csv to List
lName.Add("Hoper");
Console.WriteLine(lName[2]);




