//DateTime format

using System.Globalization;


DateTime today = DateTime.Now;

DateTime Birthday = DateTime.ParseExact("10/30/2001", "M/dd/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(Birthday.ToString());

Console.WriteLine(Birthday.ToString("MMMM dd,yyyy hh:mm tt zzz"));