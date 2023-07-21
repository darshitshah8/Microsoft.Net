namespace InheritanceMiniProject
{
    internal partial class Program
    {
        public interface IPurchasable : IInventoryItem
        {
            void Purchase();
        }
    }
}
