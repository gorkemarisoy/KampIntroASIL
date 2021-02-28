using System;

namespace Donguler // tekrar eden işlemler için kullanırız.
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı"; // bunlar yerine dizilerde tanımlamak daha mantıklı belki burda yüzlerce ürün olacak. Dinamik olsun istiyoruz. 
            string kurs2 = "Programlama başlangıç için temel kurs"; // böyle statik programla olur
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array - dizilerde tutarız yukarıdaki verileri

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlama başlangıç için temel kurs", "Java", "python", "C#" }; // string[] kurslar = kursları getir diyoruz gerçek hayatta


            for (int i = 0; i < kurslar.Length; i++) // for yaz tab tab yap, iki defa tab bas. // i++1 1 er arttır demek //İ=i+2 2 şer arttır demek i+=2 aynı şey //length eleman sayısı demektir.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) // sarıların üzerinde çift tıkla değiştir. dizi temelli yapıları tek tek dönmeye yarıyor. istersen kurs yerine başka bir şeyde yazabiliriz. dizileri kolay dolaşmak için kullanırız forech'i
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
