using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Linear_serach
{
    internal class LinearSearch
    {
        /*Linear Search, bir dizide (array) belirli bir değeri bulmak için kullanılan basit bir arama yöntemidir.
         Bu algoritma, dizinin başından başlar ve her bir elemanı tek tek kontrol eder. Eğer aranan değer bulunursa, algoritma durur ve bulunan elemanın indeksini veya true değerini döndürür.
         Eğer değer bulunamazsa, false veya -1 gibi bir değer döndürür.*/

        // ------>>>>>
        // Avantajları: Kolay ve anlaşılırdır.
        //  Dezavantajları: Büyük veri kümelerinde yavaş çalışabilir(O(n) zaman karmaşıklığına sahiptir).
        // Kullanım Alanları: Küçük veri kümelerinde veya sıralanmamış listelerde kullanılır.


        // Örnek bir dizi oluşturuyoruz. Bu dizi içinde arama yapacağız.
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Aranacak değeri belirliyoruz. Bu örnekte 4'ü arıyoruz.
        int key = 4;

        // LinearSearch fonksiyonunu çağırıyoruz ve sonucu ekrana yazdırıyoruz.
        bool result = LinearSearch(numbers, key);

        Console.WriteLine("Aranan değer bulundu mu? " + result);
    

    // LinearSearch fonksiyonu: Dizi içinde belirli bir değeri arar.
    static bool LinearSearch(int[] array, int key)
        {
            // Dizinin uzunluğu kadar bir döngü başlatıyoruz.
            for (int i = 0; i < array.Length; i++)
            {
                // Eğer dizinin i. elemanı aranan değere eşitse, true döndürüyoruz.
                if (array[i] == key)
                {
                    Console.WriteLine($"Aranan değer {key}, dizinin {i}. indeksinde bulundu.");
                    return true;
                }
            }

            // Eğer döngü bittiğinde değer bulunamadıysa, false döndürüyoruz.
            Console.WriteLine($"Aranan değer {key} dizide bulunamadı.");
            return false;
            


            // ******************************************** // 


            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            //Key means what value we are searching for

            bool LinearSearch(int[] array, int key)

            {
                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] == key)
                    {
                        return true;
                    }
                }
                return false;
            }

            Console.WriteLine(LinearSearch(array, 4));
        }
    } 
}

