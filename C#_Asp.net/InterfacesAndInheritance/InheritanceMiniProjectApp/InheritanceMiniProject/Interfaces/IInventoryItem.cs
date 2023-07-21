namespace InheritanceMiniProject
{
    internal partial class Program
    {
        //Interfaces    
        public interface IInventoryItem 
        {
             string ProductName { get; set; }
             int QuantityInStock { get; set; }
        }
    }
}
