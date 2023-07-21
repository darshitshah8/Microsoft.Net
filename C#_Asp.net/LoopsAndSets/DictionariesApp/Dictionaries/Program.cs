// KEY = STRING VALUE = STRING
Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["john"] = "veda";
lookup["robert"] = "yeda";
lookup["joe"] = "soe";
lookup["martin"] = "vara";
lookup["ojas"] = "lates";
Console.WriteLine($"the surname of john is {lookup["john"]} ");





// KEY = INT VALUE = STRING
Dictionary<int, string> employee = new Dictionary<int, string>();
employee[1] = "Sunday";
employee[2] = "Monday";
employee[3] = "Tuesday";
employee[4] = "Wednesday";
employee[5] = "Thusday";
employee[6] = "Friday";
employee[7] = "Satday";
Console.WriteLine($"6th day of week is {employee[6]}");




// KEY = STRING VALUE = INT
Dictionary<string, int> rollNumber = new Dictionary<string, int>();
rollNumber["Bumrah"] = 12;
rollNumber["tim"] = 23;
rollNumber["meet"] = 35;
rollNumber["jesal"] = 57;

Console.WriteLine($"Bumrah's roll no is {rollNumber["Bumrah"]}");
