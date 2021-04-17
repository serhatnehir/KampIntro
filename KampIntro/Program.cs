using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori"; //type safety - tip güvenliği , bir şey tanımlamak için onun önüne veri tipini tanımlamak zorundayız
                                                 // Do not repeat yourself - kendini tekrarlama
                                                 // kategori etiketi bir değer tutucudur, alias

            int ogrenciSayisi = 32000; //tam sayıları tutar
            double faizOrani = 1.45; //ondalıklı sayı tiplerini tutar

            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişim olmadı");
            }



            if (sistemeGirisYapmisMi == true) //if yazınca iki kez tab'a bas
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
