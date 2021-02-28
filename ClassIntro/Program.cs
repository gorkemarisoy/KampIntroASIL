using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs(); //Class’ın değişkenini ayarlamak için yapacağın hareket bu.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demioğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 }; // böyle yaparsan içinde Kurs tutabilirsin bir öncekinde içinde sadece string tutabilirsin. string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlama başlangıç için temel kurs" ,"Java", "python", "C#"};

            foreach (var kurs in kurslar) // kurs burda takma isim
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs  // class yaz iki kere tab tuşuna bas,  Bir class oluşturmak için yapacağın hareket bu
    {
        public string KursAdi { get; set; } // prop yaz iki kere tab , prop; property den geliyor. özellik
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
