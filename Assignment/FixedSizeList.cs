using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV01.Assignment
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public FixedSizeList(int capacity)
        {
            items = new T[capacity];
            count = 0;

            if (capacity <= 0)
                Console.WriteLine("-1");

        }

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                Console.WriteLine("Can't add more items The list is full!");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index is out of range!");
            }

            return items[index];
        }

        public int Count => count;

        public int Capacity => items.Length;

        public void PrintAll()
        {
            Console.WriteLine("Items in list: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"[{i}] = {items[i]}");
            }
        }
    }
}
