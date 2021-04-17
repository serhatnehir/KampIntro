using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); //Class'ın örneği, class olacağı zaman newlemen lazım
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};


            // type safe - tip güvenliği programlama dili çalışacağı tipi bilmek ister
            foreach (var urun in urunler) //sağdan sola in urunler = urunler dizinini tek tek gezer, urun = aşağıdaki süslü parantezin içindeki urunleri döner, Urun 
            {
                //<li></li> kullanıcı bunu görür
                //Console.WriteLine(""); bu programcının yazdığını görmesi için
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati + " TL");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("--------------Metotlar--------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 1);
            sepetManager.Ekle2("Elma", "Kırmızı elma", 5, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 20, 5);


            //Console.WriteLine();  cw tab tab

        }
    }
}


// metotlar tekrar tekrar kullanılabilir - Dont repeat yourself (DRY) - kendini tekrar etme
// Clean Code - Best Practice - temiz kod yazma