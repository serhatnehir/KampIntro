using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralları
        //syntax - yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti) //çok hatalı bir kullanım ama piyasada çok kullanılıyor
        { Console.WriteLine("Tebrikler, sepete eklendi :" + urunAdi); }
    }
}
