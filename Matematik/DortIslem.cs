using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matematik
{
    class DortIslem
    {

        //Topla(2,3)
        public void Topla(int sayi1, int sayi2)  // void git bişeyi yap demek, yani bi yere yazdır, oku ekrana yaz gibi komut olması laszım
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }

        //default parameter

        int sayi1 = 10;
      
        public void Cikar(ref int sayi1, int sayi2=30)  // ikinci parametre verilmezse eğer default olarak 30 kullanır
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + fark);
        }
        //ref sayi1 şeklinde tanımlasaydık metod içinde sayi1 diye tanımladığımız değişkeni referans alarak gönderecekti.
        //dolayısı ile metod içinde sayi1 değiştirilirse orjinal sayi1 in değeri de değişir.
        //diğer türlü sayi1 sadece bir rakam olarak gider ve değişmez.
        //out 'da ref gibi fakat ilk değer atanmış olmasına gerek yoktur.

        public void Carp(int sayi1, int sayi2 ) 
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + carpim);
        }

        public void Carp(int sayi1, int sayi2, int sayi3) // aynı isimle ve aynı isimli parametreler ile farklı iş yapan methodlar yazılabilir
        {                                                               //METHOD OVERLOADING
            int carpim = sayi1 * sayi2 * sayi3;
            Console.WriteLine("Sonuç : " + carpim);
        }

       
        public void Topla2(params int[] numbers) //params istediğimiz kadar aynı tipte parametre gönderebileceğimiz anlamına gelir.
                                                //yani METHOD OVERLOADING yaparken ayrı ayrı yazmaya gerek kalmaz, kaç tane gelirse o kadar yapar
        {
            int toplam2 = numbers.Sum();   // gelen numbers dizisini topla demek
            Console.WriteLine("sonuç   :" + toplam2);
        }


    }
}
