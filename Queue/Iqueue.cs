using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Queue
{
    public interface IQueue<T> : IEnumerable<T>
    {
        int Size();
        void Enqueue(T item);
        T Dequeue();
        bool Contains(T item);
        T Access(int position);
    }

}
