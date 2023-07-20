using System;
using System.Collections;
using Lab8_Phils_Lending_Library.Interfaces;

namespace Lab8_Phils_Lending_Library.Classes
{
    public class Bag<T> : IBag<T>
    {
        private readonly List<T> BackPack;

        // Constructor for the Bag class
        public Bag()
        {
            BackPack = new List<T>();
        }

        // Gets the enumerator for iterating over the items in the bag
        public IEnumerator<T> GetEnumerator()
        {
            return BackPack.GetEnumerator();
        }

        // Gets the non-generic enumerator for iterating over the items in the bag
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        // Adds an item to the bag
        public void Pack(T item)
        {
            if (item != null)
            {
                BackPack.Add(item);
            }
        }

        // Removes and returns the item at the specified index from the bag
        public T Unpack(int index)
        {
            if (index >= 0 && index < BackPack.Count)
            {
                T item = BackPack[index];
                BackPack.RemoveAt(index);
                return item;
            }
            else
            {

                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
        }

    }
}
