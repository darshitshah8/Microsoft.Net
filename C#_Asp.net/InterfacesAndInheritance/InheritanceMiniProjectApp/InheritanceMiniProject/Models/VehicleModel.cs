using System;

namespace InheritanceMiniProject
{
    internal partial class Program
    {
        public class VehicleModel : InventoryItemModel , IPurchasable,IRentable
        {
            public decimal DealerFee { get; set; }

            public void Purchase()
            {
                QuantityInStock -= 1;
                Console.WriteLine("This vehicle has been purchased");
            }
            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine("This Vehicle has been rented");
            }

            public void ReturnRental()
            {
                QuantityInStock += 1;
                Console.WriteLine("This Vehicle has been returned");
            }

        }
    }
}
