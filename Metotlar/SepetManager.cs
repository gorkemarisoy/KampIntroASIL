using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention - isimlendirme
        //syntax - yazım şekilleri
        public void Ekle(Urun urun) // pythonda ki def. Ekle yi çağırınca bloğun içi çağrılır. Urunler 'e parametre diyoruz.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // bu iyi bir yazma şekli değil.
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " + urunAdi);
        }


    }


}

