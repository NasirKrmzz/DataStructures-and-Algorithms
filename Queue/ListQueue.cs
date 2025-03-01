using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Queue
{
    public class ListQueue<T> : IQueue<T>
    {
        List<T> data;

        public ListQueue(int capacity)
        {
            data = new List<T>(capacity);
        }

        public ListQueue()
        {
            data = new List<T>();
        }

        public int Size()
        {
            return data.Count;
        }

        public void Enqueue(T item)
        {
            data.Add(item);
        }

        public T Dequeue()
        {
            if (data.Count == 0)
            {
                throw new InvalidOperationException("queue is empty");
            }
            T itemToDelete = data.ElementAt(0);
            data.RemoveAt(0);
            return itemToDelete;
        }

        public T Access(int position)
        {
            if (data.Count == 0)
                throw new InvalidOperationException("queue is empty");

            if (position >= data.Count)
                throw new InvalidOperationException($"no item found in the queue at given position {position}");

            return data.ElementAt(position);
        }

        public bool Contains(T item)
        {
            return data.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
