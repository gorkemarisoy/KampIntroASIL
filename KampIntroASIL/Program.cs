using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // değer tutucu, alias-=kategoriEtiketi

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; // tam sayılar
            double faizOrani = 1.45; // ondalıklı sayılar
            bool sistemeGirisYapmisMi = true; //şart blokları gerçek hayatta burası bir veri kaynağından gelir. burda true yazdığımıza bakma , sistemeGirisYapmısMıBirBak yazılır aslında
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) // Şart Blokları
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisYapmisMi == true) //if yazdıktan sonra iki defa tab tuşuna bas hızlı bir şekilde oluşturuyor
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else // iki defa tab tuşuna bas
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi); // cw yazıp iki kere tab tuşuna basarsak hızllı bir şekilde Console.Writeline yazıyor


        }
    }
}
