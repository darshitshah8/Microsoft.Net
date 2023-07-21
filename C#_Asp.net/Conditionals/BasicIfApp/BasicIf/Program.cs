// MODULE: CONDITIONALS
// TOPIC : BASIC IF

Console.Write("enter your name ");
string? name = Console.ReadLine();
string lastName;
if(name.ToLower() == "darshit") 
    //name.ToLower() = TO CONVERT STRING INTO LOWER CASE IF IT IN UPPER CASE
{
    Console.WriteLine($"welcome {name} shah");
    lastName = "Shah";
}
else
{
    Console.WriteLine($"Welcome {name}");
    lastName = "undefined";
}
Console.WriteLine($"Last Name is {lastName}");
Console.WriteLine("End of the program");




//Console.WriteLine(lName); // not valid Beacause lName is between {} of if statement , it only work in {} of if statement




// basic if else 
//bool isComplete = true;
//if (isComplete) 
//{
//    Console.WriteLine("the statemnt is true");
//}
//else
//{
//    Console.WriteLine("the statement is false");
//}
//OR  (both give same output)
//if (isComplete)
//    Console.WriteLine("the statemnt is true");
//else
//    Console.WriteLine("the statement is false");







//Practices

//if (name != "darshit")
//{
//    Console.Write("Enter your surname: ");
//    string? lName = Console.ReadLine();
//   Console.WriteLine($"Welcome, {name} {lName}");
//}





//NOTE: it only print one life after if and else when there is no use of {}