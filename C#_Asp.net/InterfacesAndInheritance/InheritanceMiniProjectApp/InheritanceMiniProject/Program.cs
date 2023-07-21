using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentales = new List<IRentable>();
            List<IPurchasable> purchase = new List<IPurchasable>();


            var vehicle = new VehicleModel { DealerFee = 25 , ProductName = "Kia" };
                
            var book  = new BookModel { ProductName = "How to become rich in one day", NumberOfPages = 390 };
            var excavator = new ExcavatorModel { ProductName = "BullDozer", QuantityInStock = 2 };


            rentales.Add(vehicle);
            rentales.Add(excavator);

            purchase.Add(vehicle);
            purchase.Add(book);

            Console.Write("do you want to rent or purchase ? (rent / Purschase) : ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentales)
                {
                    Console.WriteLine($"Product Name : {item.ProductName} ");
                    Console.Write("Do you want to rent this item ? (yes/no)  : ");
                    string wantToRent = Console.ReadLine();
                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();    
                    }

                    Console.Write("Do you want to return this item ? (yes/no)  : ");
                    string wantToReturn = Console.ReadLine();
                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchase)
                {
                    Console.WriteLine($" Product name : {item.ProductName}");
                    Console.Write("Do you want to purchase this item ? (yes/no)  : ");
                    string wantToPurchase = Console.ReadLine();
                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }
            Console.WriteLine("We are Done");
            Console.ReadLine();
        }
    }
}
