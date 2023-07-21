namespace InheritanceMiniProject
{
    internal partial class Program
    {
        public interface IRentable : IInventoryItem
        {
            void Rent();
            void ReturnRental();
        }
    }
}
