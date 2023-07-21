using System;

namespace HomeworkExtentionMethod
{
    public static class ExtentionMethod
    {
        public static PersonModel SetDefaultAge(this PersonModel person, int age)
        {
                
            person.Age = age; 
            return person;
        }
        public static void PrintMessage(this PersonModel person,string firstName,string lastName)
        {

            person.FirstName = firstName;
            person.LastName = lastName;

            Console.WriteLine($"hello {person.FirstName} {person.LastName} your age is {person.Age}");
        }

    }


}
