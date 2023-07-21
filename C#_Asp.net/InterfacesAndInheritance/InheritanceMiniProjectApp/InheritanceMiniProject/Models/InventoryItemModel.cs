namespace InheritanceMiniProject
{
    internal partial class Program
    {
        //CLASSES

        public class InventoryItemModel : IInventoryItem
        {
            public string ProductName { get; set; }
            public int QuantityInStock { get; set; }
        }
    }
}
