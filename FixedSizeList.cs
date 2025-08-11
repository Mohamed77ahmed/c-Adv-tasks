using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class FixedSizeList<T>
    {
        private int count = 0;
        private T[] Items;
        public int Capacity { get; set; }
        public FixedSizeList(int _capacity)
        {
            Capacity = _capacity;
           Items = new T[Capacity]; 
            if (_capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");
            ;
        }

        public void Add(T item)
        {
            if (count >=Items.Length)
                throw new InvalidOperationException("Cannot add more items: list is full.");

            Items[count] = item;
            count++;

        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("invalid index");
            return Items[index];
        }
         
        public void print()
        {
            for (int i = 0; i < Capacity; i++)
                Console.WriteLine(Items[i]);

        }
        
    }
}
