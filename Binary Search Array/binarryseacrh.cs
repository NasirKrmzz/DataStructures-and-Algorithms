using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Binary_Search_Array
{
    internal class binarryseacrh
    {
        // Binary Search, telefon rehberi gibi sıralı bir kitabı ararken kullandığımız yönteme benzer:
        /* 
         * Önemli Not: Bu algoritma SADECE sıralı verilerde çalışır. Sıralı olmayan verilerde işe yaramaz. 
           Temel Prensip: Her seferinde arama alanını yarıya indirerek aradığınız değeri bulmak.
            

           * Başlangıç (start) ve bitiş (end) noktalarını belirle
           * Orta noktayı (midpoint) hesapla: (start + end) / 2
           * Orta noktadaki değeri aradığın değerle karşılaştır
           * Eğer eşitse, aradığın değeri buldun
           * Eğer aradığın değer orta noktadan küçükse, yeni bitiş noktasını orta nokta olarak belirle
           * Eğer aradığın değer orta noktadan büyükse, yeni başlangıç noktasını orta nokta + 1 olarak belirle
           * Bu adımları aradığın değeri bulana kadar tekrarla
         */

        // [-15, 2, 7, 20, 30, 54] dizisinde 2 değeri aranıyor:
        /*
         İlk Adım:

            - start = 0, end = 5
            - midpoint = (0 + 5) / 2 = 2.5 → 2 (ondalık kısım atılır)
            - arr[2] = 7, bu 2'den büyük
            - Yeni end = 2

         İkinci Adım:

            - start = 0, end = 2
            - midpoint = (0 + 2) / 2 = 1
            - arr[1] = 2, bu aradığımız değer
            - Değeri bulduk, işlem tamamlandı
         */
        // Binary Search algoritması uygulaması


        //*********************************************

        // Binary Search algoritması uygulaması
        static int BinarySearch(int[] arr, int value)
        {
            // Başlangıç ve bitiş noktalarını belirle
            int start = 0;
            int end = arr.Length - 1;

            // Başlangıç bitiş noktasını geçmediği sürece devam et
            while (start <= end)
            {
                // Orta noktayı hesapla
                int midpoint = (start + end) / 2;

                // Orta noktadaki değeri kontrol et
                if (arr[midpoint] == value)
                {
                    // Değeri bulduk, midpoint'i döndür
                    return midpoint;
                }
                // Eğer aradığımız değer orta noktadan küçükse
                else if (arr[midpoint] > value)
                {
                    // Yeni bitiş noktası olarak orta noktayı belirle
                    end = midpoint - 1;
                }
                // Eğer aradığımız değer orta noktadan büyükse
                else
                {
                    // Yeni başlangıç noktası olarak orta nokta + 1'i belirle
                    start = midpoint + 1;
                }
            }

            // Değer bulunamadıysa -1 döndür
            return -1;
        }
        static void Main(string[] args)
        {
            // Test etmek için örnek dizi
            int[] intArray = { -15, 2, 7, 20, 30, 54 };

            // Binary Search ile 2 değerini arayalım
            int result = BinarySearch(intArray, 2);
            Console.WriteLine($"Aranan değer 2, dizide {result}. indekste bulundu.");

            // Dizide olmayan bir değeri arayalım
            int notFound = BinarySearch(intArray, 25);
            Console.WriteLine($"Aranan değer 25: {(notFound == -1 ? "Bulunamadı" : notFound + ". indekste bulundu")}");

            // Algoritmanın adım adım çalışmasını göstermek için
            Console.WriteLine("\nAdım adım binary search örneği:");
            int searchValue = 7;
            Console.WriteLine($"Aranan değer: {searchValue}");
            BinarySearchWithSteps(intArray, searchValue);

            Console.ReadLine();
        }
    }
}
}
