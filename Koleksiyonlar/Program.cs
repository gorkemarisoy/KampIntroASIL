using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
           // string[] isimler = new string[] {"Görkem", "Ali", "Veli", "Selin"};
           // Console.WriteLine(isimler[0]);
           // Console.WriteLine(isimler[1]);
           // Console.WriteLine(isimler[2]);
           // Console.WriteLine(isimler[3]);
           ////isimler[4] = "Çağrı"; //bu şekilde olmaz, dizi 4 elemanlı oluşturuldu ve ekleme yapılamaz.
           //isimler = new string[5];
           //Console.WriteLine(isimler[4]); //burda ilker gelir ama dizinin diğer elemanları silinir. dizi boşalır. 
           //                                 //yani dizilere yeni bişey eklenemez.
           //                                     //Ama KOLEKSİYONLARA eklenebilir.


           List<string> isimler2 = new List<string> {"Görkem", "Ali", "Veli", "Selin"};
           Console.WriteLine(isimler2[0]);
           Console.WriteLine(isimler2[1]);
           Console.WriteLine(isimler2[2]);
           Console.WriteLine(isimler2[3]);

           isimler2.Add("Engin"); //yapabilrim. listelere ekeleme yapılabilir. 
           Console.WriteLine(isimler2[4]);
           Console.WriteLine(isimler2[0]);

        }
    }
}
