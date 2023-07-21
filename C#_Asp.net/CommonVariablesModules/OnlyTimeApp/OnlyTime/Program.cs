//when requied only a time.

TimeOnly today = TimeOnly.Parse("8:00 AM");

TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(today);
Console.WriteLine(rightNow);