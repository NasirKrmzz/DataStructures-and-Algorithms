using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Stacks
{
    public class Stack
    {
        public int MaxSize { get; set; } // arry stack you need a maxsize to init arry 

        // this holds our arry 
        public string[] StackArry { get; set; }
        // this keeps track of the top 

        public int Top { get; set; }

        public Stack(int size)
        {
            // this holds constructor value 
            this.MaxSize = size;
            // create array withs size  
            this.StackArry = new string[MaxSize];
            // we give the top -1 because array is zero index ; if we give 0 it will skip first element
            this.Top = -1;
        }

        public void Push(string item)
        {
            Top++;
            StackArry[Top] = item;
        }
        public string Pop()
        {
            // think placeholder 
            int old_top = Top;
            Top--;
            return StackArry[old_top];
        }
        public string Peek()
        {
            return StackArry[Top];
        }
        public bool IsEmpty()
        {
            return Top == 0;
        }
        public bool IsFull()
        {
            return (Top == MaxSize - 1);
        }

    }
}
