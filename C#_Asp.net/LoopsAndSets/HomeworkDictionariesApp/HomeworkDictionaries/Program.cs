//DICTIONARY HOMEWORK

using System.Security.Cryptography.X509Certificates;

Dictionary<int , string> employee =  new Dictionary<int , string>();
employee[1] = "Burhan";    
employee[2] = "Prit";    
employee[3] = "Akash";    
employee[4] = "Dharmik";    
employee[5] = "Rahul";    
employee[6] = "Yash";    
employee[7] = "Ramesh";
string numText;
bool isValid;
do
{
Console.WriteLine("enter the Id of employee to know his/her name");
 numText = Console.ReadLine();
 isValid = int.TryParse(numText, out int idNum);
    if (isValid == false)
    {
        Console.WriteLine("enter valid id number");
    }
    else
    {
        Console.WriteLine($"id number {idNum} is {employee[idNum]}");
        break;
    }
}while(isValid == true);