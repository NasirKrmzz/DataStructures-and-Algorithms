using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Queue
{
    public class QueueApp
    {
        public static void _Main(string[] args)
        {
            IQueue<string> ATMqueue = new ListQueue<string>();
            Console.WriteLine("*********enqueue*******");
            ATMqueue.Enqueue("merve");
            Console.WriteLine($"merve geldi. kuyruk sayısı : {ATMqueue.Size()}");
            ATMqueue.Enqueue("can");
            Console.WriteLine($"can geldi. kuyruk sayısı : {ATMqueue.Size()}");
            ATMqueue.Enqueue("hüseyin");
            Console.WriteLine($"hüseyin geldi. kuyruk sayısı : {ATMqueue.Size()}");
            ATMqueue.Enqueue("hakan");
            Console.WriteLine($"hakan geldi. kuyruk sayısı : {ATMqueue.Size()}");
            Console.WriteLine();

            Console.WriteLine("*********contains*******");
            Console.WriteLine("merve kuyrukta mı?" + ATMqueue.Contains("merve"));
            Console.WriteLine("can kuyrukta mı?" + ATMqueue.Contains("can"));
            Console.WriteLine("hüseyin kuyrukta mı?" + ATMqueue.Contains("hüseyin"));
            Console.WriteLine("hakan kuyrukta mı?" + ATMqueue.Contains("hakan"));
            Console.WriteLine("onur kuyrukta mı?" + ATMqueue.Contains("onur"));
            Console.WriteLine();

            Console.WriteLine("*********foreach*******");
            foreach (var item in ATMqueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("*********access*******");
            Console.WriteLine("ilk sıradaki " + ATMqueue.Access(0));
            Console.WriteLine("ikinci sıradaki " + ATMqueue.Access(1));
            Console.WriteLine("üçüncü sıradaki " + ATMqueue.Access(2));
            Console.WriteLine("dördüncü sıradaki " + ATMqueue.Access(3));
            try
            {
                Console.WriteLine("beşinci sıradaki " + ATMqueue.Access(4));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("*********dequeue*******");
            Console.WriteLine($"kuyruk sayısı : {ATMqueue.Size()}");
            Console.WriteLine(ATMqueue.Dequeue() + " para çekti.");
            Console.WriteLine($"kuyruk sayısı : {ATMqueue.Size()}");
            Console.WriteLine(ATMqueue.Dequeue() + " para çekti.");
            Console.WriteLine($"kuyruk sayısı : {ATMqueue.Size()}");
            Console.WriteLine(ATMqueue.Dequeue() + " para yatırdı.");
            Console.WriteLine($"kuyruk sayısı : {ATMqueue.Size()}");
            Console.WriteLine(ATMqueue.Dequeue() + " para çekti.");
            Console.WriteLine($"kuyruk sayısı : {ATMqueue.Size()}");
            try
            {
                Console.WriteLine(ATMqueue.Dequeue() + " para çekti.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
