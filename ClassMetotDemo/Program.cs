using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] musteriler = new string[] { };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Serhat";
            musteri1.Soyadi = "Nehir";
            musteri1.CariHesapBakiye = 1500.50;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Cenan";
            musteri2.Soyadi = "Zor";
            musteri2.CariHesapBakiye = 100.20;

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("-----Hesap Açan Müşteriler-----");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("");

            Console.WriteLine("-----Hesabını Kapatan Müşteriler-----");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.WriteLine("");

            Console.WriteLine("-----Müşteri Listesi-----");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.WriteLine("");
        }
    }
}
