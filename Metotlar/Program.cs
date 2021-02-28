using System;

namespace Metotlar // Metotlar tekrar tekrar kullanılabilirliği sağlayan bir ortam sunuyor
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] meyveler = new string[] {"Elma", "Karpuz" }; bunun içerisinde sadece stringler tutabilirim ama ben daha farklı özelliklerde tutmak istiyorum .Oyüzden class lar var.

            Urun urun1 = new Urun(); // Bir class tanımlamak için bunu yapmamız gerekiyor. buna class'ın örneği deniliyor.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; // Burda ürün array'i oluşturduk. Bunlar normalde bir veri kaynağından gelir.

            // type -safe -- tip güvenli. aşağıda Urun veri tipidir. Urun yerine var'da yazsan olur.
            foreach (Urun urun in urunler) // urun yerine x de desen olur takma isim bu, Urun yerine var da yazsan olur
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("----------Metotlar--------------");

            //instance -class örneği oluşturma
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); // bunların hepsini başka bir sayfa olarak düşün alttakileri.
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil armut", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}


// Dont repeat yourself - DRY - Clean Code - Best Practice ( Doğru uygulama teknikleri)