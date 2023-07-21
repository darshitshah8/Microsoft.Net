//when need only a date.

DateOnly birthday = DateOnly.Parse("26/3/2002");
DateTime today = DateTime.Now;

Console.WriteLine(birthday.ToString("MMMM dd,yyyy"));
Console.WriteLine($"Today full format is {today.Date}");
