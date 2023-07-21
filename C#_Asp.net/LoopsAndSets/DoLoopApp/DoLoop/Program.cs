bool isValidAge =false;
int age;
string ageText;
//WITH WHILE
while (isValidAge == false)
{
    Console.WriteLine("Enter your age");
    ageText = Console.ReadLine();
    isValidAge = int.TryParse(ageText, out age);
    if (isValidAge == true)
    {
        Console.WriteLine($"You are {age} old");
    }
}
//WITH DO WHILE
do
{
	Console.Write("Enter Your age: ");
 ageText = Console.ReadLine();

isValidAge = int.TryParse(ageText, out age);

if (isValidAge == false)
{
    Console.WriteLine("That was an valid age.");
} 
} while (isValidAge == false) ;
Console.WriteLine($"Your age is {age}");


//INFINTE LOOP

//int infLoop = 0;    
//do
//{
//    Console.WriteLine(infLoop);
//    infLoop+=3;
//} while (infLoop !=10);





//Structure
//do
//{

//}while(true);

//while (true)
//{

//}