using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Queue
{
    internal class BasicQueue
    {
        public class BasicQueue<T> : IQueue<T>
        {
            private T[] data;
            private int front;
            private int end;
            private int count;

            public BasicQueue(int capacity)
            {
                data = new T[capacity];
                front = -1;
                end = -1;
            }

            public BasicQueue() : this(1000)
            {
            }

            public int Size()
            {
                return count;
            }

            public void Enqueue(T item)
            {
                if (count == data.Length)
                {
                    throw new InvalidOperationException("queue is already full");
                }
                data[++end] = item;
                if (count == 0)
                {
                    front++;
                }
                count++;
            }

            public T Dequeue()
            {
                if (count == 0)
                {
                    throw new InvalidOperationException("queue is already empty");
                }
                T item = data[front++];
                if (front > end)
                {
                    front = -1;
                    end = -1;
                }
                count--;
                return item;
            }

            public bool Contains(T item)
            {
                if (count == 0)
                {
                    return false;
                }
                for (int i = front; i <= end; i++)
                {
                    if (data[i].Equals(item))
                    {
                        return true;
                    }
                }
                return false;
            }

            public T Access(int position)
            {
                if (count == 0)
                    throw new InvalidOperationException("queue is empty");

                if (position < front && position > end)
                    throw new InvalidOperationException($"no item found in the queue at given position {position}");

                int actualIndex = 0;
                T foundItem = default(T);
                for (int i = front; i <= end; i++)
                {
                    if (actualIndex == position)
                    {
                        foundItem = data[i];
                        break;
                    }
                    actualIndex++;
                }
                return foundItem;
            }

            public IEnumerator<T> GetEnumerator()
            {
                for (int i = front; i <= end; i++)
                {
                    yield return data[i];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
}
