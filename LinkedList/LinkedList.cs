using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.LinkedList
{
    internal class LinkedList
    {
        // LinkedList, dinamik veri yapılarından biridir. Dizilerden farklı olarak, elemanlar bellekte ardışık olarak tutulmaz.
        // Bunun yerine, her eleman (node) değerini ve bir sonraki elemana referansını (pointer) içerir.
        // ✅ Dinamik Boyut: Eleman ekleyip çıkarırken yeniden boyutlandırma gerektirmez.
        // ✅ Hızlı Ekleme / Silme: Ortaya veya başa ekleme/silme işlemleri dizilere göre daha hızlıdır.
        //✅ Bellek Yönetimi: Kullanılmayan elemanlar temizlenebilir, bellekte esneklik sağlar.

        static void Main()
        {
            C#’ta Hazır LinkedList Kullanımı
             LinkedList oluşturuyoruz(string türünde)
            LinkedList<string> liste = new LinkedList<string>();

            Eleman ekleme
            liste.AddFirst("Ali");          // Başa ekler
            liste.AddLast("Veli");          // Sona ekler
            liste.AddLast("Ayşe");

            Ali’den sonra bir eleman ekleme
            LinkedListNode<string> aliNode = liste.Find("Ali");
            liste.AddAfter(aliNode, "Mehmet");

            Listeyi yazdırma
            Console.WriteLine("LinkedList Elemanları:");
            foreach (string isim in liste)
            {
                Console.WriteLine(isim);
            }

            Eleman silme
            liste.Remove("Veli");

            Console.WriteLine("\nVeli silindikten sonra:");
            foreach (string isim in liste)
            {
                Console.WriteLine(isim);
            }
        }

        // **********************************************************// 


        //  burada LinkedList sınıfı oluşturulmuş ve Add, AddFirst, Print ve Remove metotları tanımlanmıştır.

        private Node head;  // Listenin başı (ilk node)

        // Sona eleman ekleme
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null) // Liste boşsa
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null) // Son node’a kadar git
            {
                current = current.Next;
            }
            current.Next = newNode; // Yeni node’u sona ekle
        }

        // Başa eleman ekleme
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head; // Yeni node’un next’i eski head olsun
            head = newNode;      // Head’i yeni node yap
        }

        // Listeyi yazdırma
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        // Belirli bir elemanı silme
        public void Remove(int data)
        {
            if (head == null) return; // Liste boşsa bir şey yapma

            if (head.Data == data) // Eğer silinecek eleman baştaysa
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null) // Eleman bulunduysa
            {
                current.Next = current.Next.Next; // Bir sonrakini atla
            }
        }

        
    }
}

