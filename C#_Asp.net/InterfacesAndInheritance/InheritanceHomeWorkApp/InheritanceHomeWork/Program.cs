using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{
    public partial class Program
    {   
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Boat());
            vehicles.Add(new Car());
            vehicles.Add(new MoterCycle());

            foreach (var vehicle in vehicles)
            {
                if(vehicle is MoterCycle motercycle)
                {
                    motercycle.Start();
                    motercycle.EnginePower = 1200;
                }
                if(vehicle is Boat boat) 
                {
                    boat.Seating = 3;
                }
                if(vehicle is Car car) 
                {
                    car.NumberOfDoors = 4;
                }
            }
            Console.ReadLine();
        }
    }
}
