using System;

namespace InheritanceMiniProject
{
    internal partial class Program
    {
        public class ExcavatorModel : InventoryItemModel , IRentable
        {
            public void Dig()
            {
                Console.WriteLine("I'm Digging");
            }

            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine("This Excavator has been rented");
            }

            public void ReturnRental()
            {
                QuantityInStock += 1;
                Console.WriteLine("This Excavator has been returned");

            }
        }
    }
}
