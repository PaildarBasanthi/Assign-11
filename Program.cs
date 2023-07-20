using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize LargeDataCollection with initial data

            // Create an instance of LargeDataCollection and populate it with initial data.
            var initialData = new object[] { 1, 2, 3, "hello", "world" };
            var largeDataCollection = new LargeDataCollection(initialData);

            // Add more elements.
            largeDataCollection.Add(4);
            largeDataCollection.Add("extra data");

            // Access elements by index.
            object element = largeDataCollection.GetElement(2);
            Console.WriteLine("Element at index 2: " + element);

            // Remove an element.
            bool isRemoved = largeDataCollection.Remove(3);
            Console.WriteLine("Element removed: " + isRemoved);

            // Explicitly call Dispose to release resources and free up memory.
            largeDataCollection.Dispose();
        }
    }
}
