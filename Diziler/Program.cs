using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler = new string[3]; // 3 öğrenciden oluşan bir dizi tanumladık
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "görkem";
            ogrenciler[2] = "ali";


            string[] ogrenciler2 = {"Görkem", "Ali", "Veli"}; // bu şekilde de olabilir

            foreach (var ogrenci in ogrenciler2)
            {
                Console.WriteLine(ogrenci);
            }


            string[,] cografiBolgeler = new string[5, 3]
            {
                {"ist", "İzmit", "Balıkesir"},
                { "ankara", "kocaeli", " adana"},
                {"a", "b", "c"},
                { "d", "e", "f"},
                {"g", "h", "ı"}
                
            };

            for (int i=0; i<= cografiBolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= cografiBolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(cografiBolgeler[i,j]);
                }
            }
        }
    }
}
