using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Array
{
    internal class Array
    {
        /*  📌 Diziler Nedir?
            * Diziler, sabit uzunlukta bir veri yapısıdır.
             * Bellekte yan yana(contiguous) saklanır ve bu yüzden hızlı erişim sağlarlar.
              * Hızlı veri okuma & yazma için idealdir ama eleman ekleme/silme işlemleri verimli değildir. */

         /* 1️⃣ Dizinin Sonuna Eleman Ekleme(Kolay ve Hızlı! 🚀
                 Direkt dizinin en sonuna eleman eklenir.
                 Bellekte yeni yer ayrılmaz, dizinin uzunluğu güncellenir.
                 Zaman Karmaşıklığı: O(1) */

        int[] dizi = new int[5] { 1, 2, 3, 4, 5 };
        int yeniEleman = 6;
        dizi[dizi.Length - 1] = yeniEleman; // Son elemanı 6 yapar  

         **********************************************************************************

            /* 2️⃣ Dizinin Başına Eleman Ekleme(Zor ve Yavaş 😰)
                Bütün elemanları sağa kaydırıp ilk elemanı değiştirmek gerekir.
                Her eleman bir sonraki indekse taşınır, en başa yeni eleman eklenir.
                Zaman Karmaşıklığı: O(n)*/
                
                    int[] dizi = new int[6] { 0, 1, 2, 3, 4, 5 };
                int yeniEleman = 99;  

                for (int i = dizi.Length - 1; i > 0; i--)  
                    {  
                        dizi[i] = dizi[i - 1]; // Elemanları sağa kaydır  
                     }
                          dizi[0] = yeniEleman; // İlk elemanı değiştir  

        **********************************************************************************

                   /* 3️⃣ Dizinin Ortasına Eleman Ekleme(Orta Seviye Zorluk 😓)
                        Belli bir indekse eleman eklemek için geri kalan elemanları sağa kaydırmak gerekir.
                        Zaman Karmaşıklığı: O(n)*/
                               int[] dizi = new int[6] { 1, 2, 3, 4, 5, 0 };
                int yeniEleman = 99;
                int index = 2; // 3. sıraya ekle  

                    for (int i = dizi.Length - 1; i > index; i--)  
                    {  
                        dizi[i] = dizi[i - 1];  
                    }
                    dizi[index] = yeniEleman;

        **********************************************************************************

                   /* 2️⃣ Dizinin Başından Eleman Silme (Orta Seviye Zorluk 😰)
                İlk elemanı silmek için tüm elemanları sola kaydırmak gerekir.
                Bütün elemanlar bir pozisyon sola kaydırılır, son eleman artık kullanılmaz.
                Zaman Karmaşıklığı: O(n)(Çünkü tüm elemanları kaydırmak gerekir.)*/

                int[] dizi = new int[6] { 1, 2, 3, 4, 5, 6 };
                int uzunluk = dizi.Length;

                    for (int i = 0; i < uzunluk - 1; i++)
                    {
                        dizi[i] = dizi[i + 1]; // Tüm elemanları sola kaydır  
                    }
                uzunluk--;  // Son elemanı 'sildik'

        **********************************************************************************

                /* 3️⃣ Dizinin Ortasından Eleman Silme (Zor ve Yavaş 😓)
                Belli bir indeksteki elemanı silmek için geri kalanları sola kaydırmak gerekir.
                Örneğin, 3. elemanı silmek için 4. ve sonrasını sola kaydırırız.
                Zaman Karmaşıklığı: O(n)(Kaydırma işlemi nedeniyle yavaş.)*/

                int[] dizi = new int[6] { 1, 2, 3, 4, 5, 6 };
                int uzunluk = dizi.Length;
                int silinecekIndex = 2; // 3. elemanı sil  

                    for (int i = silinecekIndex; i < uzunluk - 1; i++)
                    {
                        dizi[i] = dizi[i + 1]; // Elemanları sola kaydır  
                    }
                uzunluk--;  // Son elemanı 'sildik'



    }
}
