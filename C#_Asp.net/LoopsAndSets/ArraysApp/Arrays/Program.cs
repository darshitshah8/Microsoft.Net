// 0 Based counting = 0,1,2,3,4,5,6   => Programming Language
// 1 Based counting = 1,2,3,4,5,6,7   => Real World

string[] firstName = new string[4];
firstName[0] = "Darshit";
firstName[1] = "John";
firstName[2] = "loe";
firstName[3] = "JOe";
Console.WriteLine($"First Names are 1. {firstName[0]}, 2. {firstName[1]}, 3. {firstName[2]}");
firstName[1] = "Bob";
Console.WriteLine($"2. 'john' is now ' {firstName[1]} '");

//Single Quote identifies a char
//Double Quote identifies a string

string names = "John,Tim,loe,kali,bob,shoe,akile"; // CSV -Comma Saprated Values
string[] firstNames = names.Split(','); //Conver CSV TO ARRAY
Console.WriteLine(firstNames[4]); // Retunr value of 4th index
Console.WriteLine(firstNames.Length); // Return Length of array
Console.WriteLine(firstNames[firstNames.Length - 2]); //Return value from last index

string[] lastName = new string[] { "Shah", "Smith", "Wick", "parkar", "stark", "rogers" };
Console.WriteLine($"the length of lastName array is {lastName.Length}");
Console.WriteLine(lastName[2]);







//PRACTICE
//for (int i = 0; i<=firstName.Length ; i++){
//    Console.WriteLine(firstName[i]);
//}
string[] name = new string[] { "himanshu", "Kali ", "abhishek" };
string[] lName = new string[] { "patel", "Das", "Nagar" };
int[] number = new int[] { 1, 2, 3 };
for (int i = 0; i < name.Length && i < number.Length && i < lName.Length; i++)
{
    Console.WriteLine($"The Name of the student is {name[i]} {lName[i]} and his roll no is {number[i]}");
}