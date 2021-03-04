using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler1 = new List<string>(); // List genericinin aynısını biz yazalım
            isimler1.Add("Görkem");
            isimler1.Add("Selin");
            isimler1.Add("a");
            isimler1.Add("v");
            isimler1.Add("s");
            isimler1.Add("b");

            Console.WriteLine(isimler1.Count);

            MyList<string> isimler2 = new MyList<string>();  //string türünde bir mylist oluşturdum.
            isimler2.Add("Görkem");
            isimler2.Add("Selin");
            isimler2.Add("a");          //Add metodu void olduğu için bunu dizide yeni yer açıp yazıyor ama birşey döndürmüyor.
            isimler2.Add("v");
            isimler2.Add("s");
            isimler2.Add("b");

            Console.WriteLine(isimler2.Count);  //Mylist altında count metodu yazdık. Get(read) only.

            Console.WriteLine(isimler2.Yaz);

        }
    }
}
