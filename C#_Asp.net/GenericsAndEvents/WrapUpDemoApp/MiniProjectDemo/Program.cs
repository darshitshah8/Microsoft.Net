using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Darshit" , LastName = "Shah", Email = "darshitshah@gmail.com"},
                new PersonModel{FirstName = "Tonydarned" , LastName = "Stark", Email = "tonystark@gmail.com"},
                new PersonModel{FirstName = "Elon" , LastName = "Musk", Email = "elonMask@gmail.com"}
            };
            List<CarModel> cars = new List<CarModel>
            {
                new CarModel{Manufacturer = "Toyota",Model="Fortuner"},
                new CarModel{Manufacturer = "Hyunai",Model="Creata"},
                new CarModel{Manufacturer = "Tata",Model="Harrier"},
            };

            DataAccess < PersonModel > peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += People_BadEntryFound;

            peopleData.SaveToCsv(people, @"C:\Users\Darshit.Shah\source\repos\GenericsAndEvents\WrapUpDemoApp\MiniProjectDemo\Temp\people.csv");

            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += Car_BadEntryFound;

            carData.SaveToCsv(cars,@"C:\Users\Darshit.Shah\source\repos\GenericsAndEvents\WrapUpDemoApp\MiniProjectDemo\Temp\cars.csv");
            Console.ReadLine();
        }

        private static void Car_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad entry found for {e.Manufacturer} {e.Model}");
        }

        private static void People_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad entry found for {e.FirstName}{e.LastName}");
        }
    }   
    }

