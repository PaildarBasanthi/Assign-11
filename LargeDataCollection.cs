using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> data; // The internal data structure to hold a large amount of data.

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            // Initialize the internal data structure and populate it with initial data.
            data = new List<object>(initialData);
        }

        public void Add(object item)
        {
            // Add an element to the collection.
            data.Add(item);
        }

        public bool Remove(object item)
        {
            // Remove an element from the collection.
            return data.Remove(item);
        }

        public object GetElement(int index)
        {
            // Get an element from the collection based on the index.
            if (index >= 0 && index < data.Count)
            {
                return data[index];
            }
            return null; // Or throw an exception if you prefer.
        }

        public void Dispose()
        {
            // Implement the IDisposable pattern to release unmanaged resources.
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Release managed resources.
                data.Clear();
                data = null;
            }
            // Release any other unmanaged resources here.
        }
    }
    }
