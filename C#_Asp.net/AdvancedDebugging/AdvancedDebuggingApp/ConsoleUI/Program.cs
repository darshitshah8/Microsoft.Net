using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            try
            {
            DiffrentMethod();

            Console.WriteLine("What is your name");
            name = Console.ReadLine();
            ComplexMethod(name);
            SimpleMethod();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("you should not be calling simple methods");
                Console.WriteLine(ex.Message);  
            }
            catch(NotImplementedException) 
            {
                Console.WriteLine("You forgot to finish your code!!!!");
            }
            catch (Exception) when(name.ToLower() == "darshit")
            {
                Console.WriteLine("you used darshit's name , didn't you??");                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }   
            finally
            {
                Console.WriteLine("I always run");
            }
            Console.ReadLine();

        }
        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "darshit") 
            {
                throw new InsufficientMemoryException("To smart for coding");
            }
            else 
            {
                throw new ArgumentException("this person isn't tim");
            }
        }
        private static void DiffrentMethod()
        {
            Console.WriteLine("This is diffrent method working prpoperly");
        }
        private static void SimpleMethod() 
        {
            throw new InvalidOperationException("you should not be calling simple methods");
        }
    }
}


//NOTE Pro Tip : Exceptions indicate unexpected behavior. create them yourself if it makes sense