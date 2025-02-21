using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.LinkedList
{
    internal class TestClass
    {
        static void Main()
        {
            LinkedList liste = new LinkedList();

            // Eleman ekleme
            liste.Add(10);       // 10 -> null
            liste.Add(20);       // 10 -> 20 -> null
            liste.AddFirst(5);   // 5 -> 10 -> 20 -> null

            // Listeyi yazdırma
            Console.WriteLine("Başlangıçtaki liste:");
            liste.Print();

            // Eleman silme
            liste.Remove(10);    // 5 -> 20 -> null

            Console.WriteLine("10 silindikten sonra:");
            liste.Print();
        }
    }
}
