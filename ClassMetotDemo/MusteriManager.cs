using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " isimli müşteri " + musteri.CariHesapBakiye + " TL bakiye ile hesap açtı.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " +  musteri.Soyadi + " isimli müşteri silindi " + musteri.CariHesapBakiye + " TL bakiyesini çekerek hesabını kapattı.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
        }
}
}
 