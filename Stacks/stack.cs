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


        static void Main(string[] args)
        {
            /* 
             1) Stack (Yığın), LIFO (Last In, First Out – Son Giren İlk Çıkar) prensibiyle çalışan bir veri yapısıdır.
             Yani en son eklenen eleman, ilk olarak çıkarılır.
             
             Stack Operasyonları
             1 ) Push(T item) → Stack'e yeni bir eleman ekler.
             2 ) Pop() → Stack’in en üstündeki elemanı çıkarır ve döndürür.
             3 ) Peek() → Stack’in en üstündeki elemanı döndürür ancak çıkartmaz.
             4 ) Count → Stack’te kaç eleman olduğunu döndürür.
             5 ) Contains(T item) → Belirtilen elemanın Stack içinde olup olmadığını kontrol eder.
             6 ) Clear() → Stack’teki tüm elemanları temizler.
            
             */

            Stack<String> banknotes = new Stack<String>();
            Console.WriteLine("Size : " + banknotes.Count());
            banknotes.Push("200 TL");
            banknotes.Push("100 TL ");
            banknotes.Push("50 TL ");
            banknotes.Push("20 TL ");
            banknotes.Push("10 TL ");
            banknotes.Push("5 TL ");

            Console.WriteLine("size :" + banknotes.Count());
            foreach (var item in banknotes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek : " + banknotes.Peek());
            Console.WriteLine("Size :" + banknotes.Count());
            Console.WriteLine(banknotes.Pop());
            Console.WriteLine(banknotes.Pop());
            Console.WriteLine("Size :" + banknotes.Count());

            foreach (var item in banknotes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
