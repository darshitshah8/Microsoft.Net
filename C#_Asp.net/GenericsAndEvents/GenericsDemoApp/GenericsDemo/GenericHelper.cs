using System.Collections.Generic;

namespace GenericsDemo
{
    public class GenericHelper<T> where T : IErrorCheck
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();

        public void CheckItemAndAdd(T item)
        {
            if (item.HasError == false)
            {
                Items.Add(item);
            }
            else
            {
                RejectedItems.Add(item);
            }


            //T test = new T();
            //Items.Add(item);
        }
    }
}

