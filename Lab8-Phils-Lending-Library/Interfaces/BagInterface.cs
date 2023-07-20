using System;
namespace Lab8_Phils_Lending_Library.Interfaces
{
    public interface IBag<T> : IEnumerable<T>
    {
        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        void Pack(T item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        T Unpack(int index);
    }
}

