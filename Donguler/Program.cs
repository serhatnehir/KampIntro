using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);

            //tüm bunları tek tek yazmak yerine array - dizi oluşturuyoruz

            string[] kurslar = new string[] // istediğim kadar kursu tek bir dizide tutabilirim
            {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Pyhton", "C++", "C#"}; //gerçek hayatta böyle tek tek yazılmaz burası bir veri kaynağından gelir


            for (int i = 0; i < kurslar.Length; i++) //programlama dilleri yazmaya 0 dan başlar
                                                     //.Length dizideki eleman sayısı kadar döner
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            //dizileri yukarıdaki gibi yazabileceğimiz gibi aşağıdaki gibi de yazabiliriz

            foreach (string kurs in kurslar) // foreach dizi temelli yapıları tek tek dönmeye yarar, kursları tek tek dolaş demek
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");


           //for (int i = 1; i < 10; i=i+2) //i = 1 başlangıç değeri, i < 10 şartımız, i++ 1, 1 arttır, i=i+2 2, 2 arttır demek
           // {                Console.WriteLine(i);            }
        }
    }
}
