using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.LinkedList
{
    public class Node
    {
            public int Data;    // Node’un içindeki veri
            public Node Next;   // Bir sonraki node’a işaret

            public Node(int data)
            {
                Data = data;
                Next = null;    // İlk başta bir sonrakine işaret yok
            }
    }
}
