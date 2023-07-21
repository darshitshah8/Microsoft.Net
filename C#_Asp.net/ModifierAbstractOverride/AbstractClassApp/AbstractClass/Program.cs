using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();    

            car.Model = "SUV";
            Console.WriteLine(car.Model);


            Console.ReadLine();
        }
    }
    public abstract class Vehicle
    {
        public string ChassesNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearOfManufactured { get; set; } 
    }
    public class Car : Vehicle 
    {
        public int NumberOfWheels { get; set; } = 4;
    }
}
